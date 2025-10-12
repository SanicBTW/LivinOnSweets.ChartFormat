using System.Runtime.Serialization;

namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a <see cref="ChartData"/> metadata.
/// </summary>
public struct ChartMetadata
{
    /// <summary>
    /// The "level" of this <see cref="ChartData"/>.
    /// </summary>
    public string Difficulty;

    /// <summary>
    /// The Beats Per Minute (BPM) of this <see cref="ChartData"/>.
    /// </summary>
    public float Bpm;

    /// <summary>
    /// The amount of grids (steps) per beat of this <see cref="ChartData"/>.
    /// </summary>
    public int GridsPerBeat;

    /// <summary>
    /// The note offset of this <see cref="ChartData"/>.
    /// </summary>
    public int NoteOffset;

    /// <summary>
    /// The version of this <see cref="ChartData"/>.
    /// </summary>
    public string Version;

    /// <summary>
    /// The serialized <see cref="Version"/>.
    /// </summary>
    [IgnoreDataMember]
    public Version SerializedVersion => new(Version);

    /// <summary>
    /// The source/author of the generated chart.
    /// </summary>
    public string? GeneratedBy;
}