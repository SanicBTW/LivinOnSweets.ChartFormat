using System.Reflection;
using LivinOnSweets.ChartFormat.Models;
using LivinOnSweets.ChartFormat.Models.Original;

namespace LivinOnSweets.ChartFormat.Adapters;

// based on https://github.com/SanicBTW/LivinOnSweets.ChartConverter/blob/master/LivinOnSweets.ChartConverter/Converters/LCFv1.cs

/// <summary>
/// The <see cref="IChartAdatper{TExternal}"/> for <see cref="JsonChartData"/>, converts the JSON structure into <see cref="ChartData"/>.
/// </summary>
public class JsonAdapter : IChartAdatper<JsonChartData>
{
    /// <summary>
    /// The name (or chart version) this adapter will be registered as inside the <see cref="ChartPipeline"/>.
    /// </summary>
    public const string ChartTypeName = "los_og";
    
    /// <inheritdoc cref="IChartAdatper{TExternal}.Adapt"/>
    public ChartData Adapt(JsonChartData source)
    {
        var assembly = Assembly.GetExecutingAssembly();

        ChartMetadata metadata = new()
        {
            Difficulty = source.Difficulty,
            Bpm = source.Bpm,
            GridsPerBeat = source.GridsPerBeat,
            NoteOffset = source.NoteOffset,
            Version = DefaultAdapter.ChartVersion.ToString(),
            GeneratedBy = $"Livin on Sweets' Chart Format v{assembly.GetName().Version}"
        };

        List<BeatHighlight> beatHighlights = [];
        beatHighlights.AddRange(
                source.BeatHighlights.Select(
                    highlight => new BeatHighlight(
                        highlight.StartBeat,
                        highlight.EndBeat,
                        highlight.Interval
                    ))
                );

        List<NoteData> notes = [];

        foreach (var note in source.Notes)
        {
            var noteData = new NoteData()
            {
                Type = note.Type,
                Lane = note.Lane,
                Start = new NotePosition(note.Beat, note.Grid),
            };
            
            // since LCFv1.1 fever is optional so we will only set it if we need to
            if (note.Fever)
                noteData.Fever = true;
            
            // If it isn't the same as the one found in the metadata add it
            if (note.GridsPerBeat != metadata.GridsPerBeat)
                noteData.GridsPerBeat = note.GridsPerBeat;
            
            if (noteData.Type == "long" && note is { EndBeat: not null, EndGrid: not null })
                noteData.End = new NotePosition(note.EndBeat.Value, note.EndGrid.Value);
            
            notes.Add(noteData);
        }

        // building up the chart data on return
        return new ChartData()
        {
            Metadata = metadata,
            BeatHighlights = [..beatHighlights],
            Notes = [..notes],
        };;
    }
}