// ReSharper disable ClassNeverInstantiated.Global
namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a standard Livin' on Sweets propietary chart format (LCF) following the latest specification.
/// </summary>
public class ChartData
{
    /// <summary>
    /// The <see cref="ChartMetadata"/> of this <see cref="ChartData"/>.
    /// </summary>
    public ChartMetadata Metadata { get; set; } = new();
    
    /// <summary>
    /// A list of available <see cref="BeatHighlight"/>'s on this <see cref="ChartData"/>.
    /// </summary>
    public List<BeatHighlight> BeatHighlights { get; set; } = [];

    /// <summary>
    /// A list of available <see cref="TimingPoint"/>'s on this <see cref="ChartData"/>.
    /// <remarks>Added in LCFv1.2</remarks>
    /// </summary>
    public List<TimingPoint> TimingPoints { get; set; } = [];

    /// <summary>
    /// A list of available <see cref="ScrollVelocity"/>'s on this <see cref="ChartData"/>.
    /// <remarks>Added in LCFv1.2</remarks>
    /// </summary>
    public List<ScrollVelocity> ScrollVelocities { get; set; } = [];

    /// <summary>
    /// A list of available <see cref="NoteData"/>'s on this <see cref="ChartData"/>.
    /// </summary>
    public List<NoteData> Notes { get; set; } = [];
}