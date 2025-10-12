// ReSharper disable ClassNeverInstantiated.Global
using System.Runtime.Serialization;
using LivinOnSweets.ChartFormat.Adapters;

namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a <see cref="ChartData"/> metadata.
/// </summary>
public class ChartMetadata
{
    /// <summary>
    /// The "level" of this <see cref="ChartData"/>.
    /// </summary>
    public string? Difficulty { get; set; }

    /// <summary>
    /// The Beats Per Minute (BPM) of this <see cref="ChartData"/>.
    /// </summary>
    public float Bpm { get; set; }

    /// <summary>
    /// The amount of grids (steps) per beat of this <see cref="ChartData"/>.
    /// </summary>
    public int GridsPerBeat { get; set; }

    /// <summary>
    /// The note offset of this <see cref="ChartData"/>.
    /// </summary>
    public int NoteOffset { get; set; }

    /// <summary>
    /// The version of this <see cref="ChartData"/>.
    /// </summary>
    public string Version { get; set; } = DefaultAdapter.ChartVersion.ToString();

    /// <summary>
    /// The serialized <see cref="Version"/>.
    /// </summary>
    [IgnoreDataMember]
    public Version SerializedVersion => new(Version);

    /// <summary>
    /// The source/author of the generated chart.
    /// </summary>
    public string? GeneratedBy { get; set; }
}