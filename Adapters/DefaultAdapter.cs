using LivinOnSweets.ChartFormat.Models;
using Tomlyn;

namespace LivinOnSweets.ChartFormat.Adapters;

// this basically accepts a stream that will ALWAYS be the TOML file stream, if something else is passed it will just return null

/// <summary>
/// The default adapter for the Livin' Chart Format spec.
/// </summary>
public class DefaultAdapter : IChartAdatper<string>
{
    /// <summary>
    /// The current version of the Livin' Chart Format Spec
    /// </summary>
    public static readonly Version ChartVersion = new(1, 1, 0);
    
    /// <summary>
    /// The name (or chart version) this adapter will be registered as inside the <see cref="ChartPipeline"/>.
    /// </summary>
    public static readonly string ChartTypeName = $"los_prop_{ChartVersion}";
    
    /// <inheritdoc cref="IChartAdatper{TExternal}.Adapt"/>
    /// <remarks>If the <paramref name="source"/> is not a TOML string with the type of <see cref="ChartData"/> it will return <c>null</c></remarks>
    public ChartData Adapt(string source)
    {
        if (!Toml.TryToModel(source, out ChartData? chartData, out var diagnostics))
        {
            // TODO bruh
            return null!;
        }

        return chartData;
    }
}