// ReSharper disable ClassNeverInstantiated.Global
namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a Beat Highlight.
/// </summary>
public class BeatHighlight
{
    /// <summary>
    /// The starting beat of this highlight.
    /// </summary>
    public int StartBeat { get; set; }
    
    /// <summary>
    /// The ending beat of this highlight.
    /// </summary>
    public int EndBeat { get; set; }

    /// <summary>
    /// The <see cref="ChartMetadata.GridsPerBeat"/> of this highlight.
    /// </summary>
    public int Interval { get; set; }
}