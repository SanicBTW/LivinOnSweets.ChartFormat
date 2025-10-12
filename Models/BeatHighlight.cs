namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a Beat Highlight.
/// </summary>
public readonly struct BeatHighlight(int startBeat, int endBeat, int interval)
{
    /// <summary>
    /// The starting beat of this highlight.
    /// </summary>
    public readonly int StartBeat = startBeat;
    
    /// <summary>
    /// The ending beat of this highlight.
    /// </summary>
    public readonly int EndBeat = endBeat;

    /// <summary>
    /// The <see cref="ChartMetadata.GridsPerBeat"/> of this highlight.
    /// </summary>
    public readonly int Interval = interval;
}