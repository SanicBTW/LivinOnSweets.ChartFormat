using LivinOnSweets.ChartFormat.Models;

namespace LivinOnSweets.ChartFormat.Adapters;

/// <summary>
/// Interface which is used to adapt <typeparamref name="TExternal"/> into <see cref="ChartData"/>.
/// </summary>
/// <typeparam name="TExternal">The source type to adapt from into a <see cref="ChartData"/>.</typeparam>
public interface IChartAdatper<in TExternal>
{
    /// <summary>
    /// Called when trying to retrieve the a chart type of <typeparamref name="TExternal"/>.
    /// </summary>
    /// <param name="source">The source chart of type <typeparamref name="TExternal"/>.</param>
    /// <returns>An adapted <see cref="ChartData"/>.</returns>
    ChartData Adapt(TExternal source);
}