// ReSharper disable ClassNeverInstantiated.Global
namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents a timing point inside the chart.
/// <remarks>Added in LCFv1.2</remarks>
/// </summary>
public class TimingPoint
{
    /// <summary>
    /// The starting time for this timing point to apply.
    /// </summary>
    public TimePosition Start { get; set; } = new();

    /// <summary>
    /// The new <see cref="ChartMetadata.Bpm"/> of the song at this point.
    /// </summary>
    public float Bpm { get; set; }

    /// <summary>
    /// The new signature numerator the Conductor should use at this point.
    /// </summary>
    public int SignatureNumerator { get; set; } = 4;

    /// <summary>
    /// The new signature denominator the Conductor should use at this point.
    /// </summary>
    public int SignatureDenominator { get; set; } = 4;
}