using LivinOnSweets.ChartFormat.Adapters;
using LivinOnSweets.ChartFormat.Models;

namespace LivinOnSweets.ChartFormat;

/// <summary>
/// A registry which holds the supported Chart Importers to retrieve charts based on the game specific format.
/// </summary>
public static class ChartPipeline
{
    private static readonly Dictionary<string, object> Importers = [];

    static ChartPipeline()
    {
        Register(DefaultAdapter.ChartTypeName, new DefaultAdapter());
    }
    
    /// <summary>
    /// Registers an <see cref="IChartAdatper{TExternal}"/> to the pipeline.
    /// </summary>
    /// <param name="version">The chart version to register this <paramref name="adapter"/> into, overriding can happen.</param>
    /// <param name="adapter">The adapter for the chart <paramref name="version"/>.</param>
    /// <typeparam name="TExternal">The source chart type for the <paramref name="adapter"/>.</typeparam>
    public static void Register<TExternal>(string version, IChartAdatper<TExternal> adapter) => Importers[version] = adapter;

    /// <summary>
    /// Loads a chart using the appropiate <see cref="IChartAdatper{TExternal}"/> previously registered through <see cref="Register{TExternal}"/>
    /// </summary>
    /// <param name="version">The <typeparamref name="TExternal"/> version name to lookup for.</param>
    /// <param name="source">The source chart to adapt <typeparamref name="TExternal"/> into <see cref="ChartData"/>.</param>
    /// <typeparam name="TExternal">The type of chart that will get adapted into <see cref="ChartData"/>.</typeparam>
    /// <returns>A freshly converted <see cref="ChartData"/> from <typeparamref name="TExternal"/>.</returns>
    /// <exception cref="Exception">When no <see cref="IChartAdatper{TExternal}"/> was registered for the chart <paramref name="version"/>.</exception>
    public static ChartData? Load<TExternal>(string version, TExternal source)
    {
        if (Importers.TryGetValue(version, out var obj) && obj is IChartAdatper<TExternal> chartData)
            return chartData.Adapt(source);

        throw new Exception($"No adapter registered for version {version}");
    }
}