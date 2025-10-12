using Newtonsoft.Json;

namespace LivinOnSweets.ChartFormat.Models.Original;

// i added the comments on the last minute, im sorry lol

/// <summary>
/// Represents the default structure of the JSON file
/// </summary>
public struct JsonChartData
{
    /// <summary>
    /// The difficulty of the chart
    /// </summary>
    [JsonProperty("level")]
    public string Difficulty;

    /// <summary>
    /// The bpm of the chart
    /// </summary>
    [JsonProperty("bpm")]
    public float Bpm;

    /// <summary>
    /// Grids per beat (steps per beat) of the chart
    /// </summary>
    [JsonProperty("gridsPerBeat")]
    public int GridsPerBeat;

    /// <summary>
    /// An array of <see cref="JsonBeatHighlight"/>'s that represents the section lines
    /// </summary>
    [JsonProperty("beatHighlights")]
    public JsonBeatHighlight[] BeatHighlights;
    
    /// <summary>
    /// Default offset of the notes
    /// </summary>
    [JsonProperty("noteOffset")]
    public int NoteOffset;

    /// <summary>
    /// An array of <see cref="JsonNoteData"/>'s that represents the notes of this chart
    /// </summary>
    [JsonProperty("notes")]
    public JsonNoteData[] Notes;
}