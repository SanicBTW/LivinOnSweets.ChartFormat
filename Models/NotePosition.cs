// ReSharper disable ClassNeverInstantiated.Global
namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a Note Position, groups the Beat and Grid properties from the original format.
/// </summary>
public class NotePosition
{
    /// <summary>
    /// The beat where the <see cref="NoteData"/>. is gonna spawn.
    /// </summary>
    public int Beat { get; set; }

    /// <summary>
    /// The grid (step) where the <see cref="NoteData"/>. is meant to be pressed.
    /// </summary>
    public int Grid { get; set; }

    /// <summary>
    /// The time where the <see cref="NoteData"/>. is meant to be pressed, similar to <see cref="Grid"/>.
    /// <remarks>Available since LCFv1.1, if existing, <see cref="Beat"/> and <see cref="Grid"/> won't be used in favor of this value.</remarks>
    /// </summary>
    public double? Time { get; set; }
}