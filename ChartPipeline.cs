using LivinOnSweets.ChartFormat.Adapters;

namespace LivinOnSweets.ChartFormat;

/// <summary>
/// A registry which holds the supported Chart Adapters to retrieve charts based on the game specific format.
/// </summary>
public static class ChartPipeline
{
    private static readonly Dictionary<string, IChartAdapter> Adapters = [];

    static ChartPipeline()
    {
        Register(DefaultAdapter.ChartFormatName, new DefaultAdapter());
    }
    
    /// <summary>
    /// Registers an <see cref="IChartAdapter"/> to the pipeline.
    /// </summary>
    /// <param name="formatId">The chart format to register this <paramref name="adapter"/> into, overriding can happen.</param>
    /// <param name="adapter">The adapter for the chart <paramref name="formatId"/>.</param>
    public static void Register(string formatId, IChartAdapter adapter) => Adapters[formatId.ToLowerInvariant()] = adapter;
    
    /// <summary>
    /// Removes a registered <see cref="IChartAdapter"/> from the pipeling.
    /// </summary>
    /// <param name="formatId">The chart format to unregister.</param>
    public static void Unregister(string formatId) => Adapters.Remove(formatId.ToLowerInvariant());

    /// <summary>
    /// Attempts to retrieve <paramref name="formatId"/> <see cref="IChartAdapter"/>.
    /// </summary>
    /// <param name="formatId">The chart format to look up.</param>
    /// <param name="adapter">The format chart adapter.</param>
    /// <returns>True if <paramref name="formatId"/> has a <see cref="IChartAdapter"/>.</returns>
    public static bool TryGetAdapter(string formatId, out IChartAdapter? adapter)
        => Adapters.TryGetValue(formatId.ToLowerInvariant(), out adapter);

    /// <summary>
    /// Attempts to retrieve <paramref name="formatId"/> <see cref="IChartAdapter"/>.
    /// </summary>
    /// <param name="formatId">The chart format to look up.</param>
    /// <param name="adapter">The format chart adapter.</param>
    /// <returns>True if <paramref name="formatId"/> has a <see cref="IChartAdapter"/>.</returns>
    public static bool TryGetAdapter<TExternal>(string formatId, out IChartAdapter<TExternal>? adapter)
    {
        if (!TryGetAdapter(formatId, out var retrieved))
        {
            adapter = null;
            return false;
        }

        if (retrieved is not IChartAdapter<TExternal> typed)
        {
            adapter = null;
            return false;
        }

        adapter = typed;
        return true;
    }
}