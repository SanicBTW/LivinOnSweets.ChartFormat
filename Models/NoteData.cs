// ReSharper disable ClassNeverInstantiated.Global
namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a Note.
/// </summary>
public class NoteData
{
    /// <summary>
    /// The type of this <see cref="NoteData"/>.
    /// </summary>
    public string Type { get; set; } = "basic";

    /// <summary>
    /// The lane of this <see cref="NoteData"/>.
    /// </summary>
    public int Lane { get; set; }

    /// <summary>
    /// The starting position of this <see cref="NoteData"/>.
    /// </summary>
    public NotePosition Start { get; set; } = new();
    
    /// <summary>
    /// The <see cref="ChartMetadata.GridsPerBeat"/> of this <see cref="NoteData"/>.
    /// </summary>
    public int? GridsPerBeat { get; set; }

    /// <summary>
    /// The fever state of this <see cref="NoteData"/>.
    /// <remarks>Optional since LCFv1.1</remarks>
    /// </summary>
    public bool? Fever { get; set; }

    /// <summary>
    /// The Beats Per Minute (BPM) that was used to parse this <see cref="NoteData"/>.
    /// <remarks>Only used on special cases, added on LCFv1.1</remarks>
    /// </summary>
    public float? Bpm { get; set; }

    /// <summary>
    /// The ending position of this <see cref="NoteData"/>, only used when <see cref="Type"/> is "long".
    /// <remarks>Only used to calculate the length of the <see cref="NoteData"/>, if time is present it will be used instead of calculating it with the <see cref="NotePosition.Beat"/> and <see cref="NotePosition.Grid"/>.</remarks>
    /// </summary>
    public NotePosition? End { get; set; }
}
