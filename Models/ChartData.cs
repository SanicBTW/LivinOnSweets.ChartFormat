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
    /// An array of the <see cref="BeatHighlight"/>'s available on this <see cref="ChartData"/>.
    /// </summary>
    public List<BeatHighlight> BeatHighlights { get; set; } = [];

    /// <summary>
    /// An array of the <see cref="NoteData"/>'s available on this <see cref="ChartData"/>.
    /// </summary>
    public List<NoteData> Notes { get; set; } = [];
}