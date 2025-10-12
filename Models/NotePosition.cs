namespace LivinOnSweets.ChartFormat.Models;

/// <summary>
/// Represents the data structure of a Note Position, groups the Beat and Grid properties from the original format.
/// <remarks>This object is only used in the TOML format.</remarks>
/// </summary>
public readonly struct NotePosition(int beat, int grid, double? time = null)
{
    /// <summary>
    /// The beat where the <see cref="NoteData"/>. is gonna spawn.
    /// </summary>
    public readonly int Beat = beat;

    /// <summary>
    /// The grid (step) where the <see cref="NoteData"/>. is meant to be pressed.
    /// </summary>
    public readonly int Grid = grid;

    /// <summary>
    /// The time where the <see cref="NoteData"/>. is meant to be pressed, similar to <see cref="Grid"/>.
    /// <remarks>Available since LCFv1.1, if existing, <see cref="Beat"/> and <see cref="Grid"/> won't be used in favor of this value.</remarks>
    /// </summary>
    public readonly double? Time = time;
}