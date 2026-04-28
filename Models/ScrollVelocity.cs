// ReSharper disable ClassNeverInstantiated.Global
namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents a change of scroll velocity in the chart.
/// <remarks>Added in LCFv1.2</remarks>
/// </summary>
public class ScrollVelocity
{
    /// <summary>
    /// The starting time for this scroll velocity to happen.
    /// </summary>
    public TimePosition Start { get; set; } = new();

    /// <summary>
    /// The multiplier of this velocity change, 1.0 being the default, 1.5 being 50% faster, etc...
    /// </summary>
    public float Multiplier { get; set; } = 1.0F;
}