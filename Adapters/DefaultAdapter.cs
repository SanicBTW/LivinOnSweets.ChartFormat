using LivinOnSweets.ChartFormat.Models;
using Tomlyn;

namespace LivinOnSweets.ChartFormat.Adapters;

// this basically accepts a stream that will ALWAYS be the TOML file stream, if something else is passed it will just return null

/// <summary>
/// The default adapter for the Livin' Chart Format spec.
/// </summary>
public class DefaultAdapter : IChartAdapter<string>
{
    /// <summary>
    /// The current version of the Livin' Chart Format Spec
    /// </summary>
    public static readonly Version ChartVersion = new(1, 1, 0);
    
    /// <summary>
    /// The chart format this adapter will be registered as inside the <see cref="ChartPipeline"/>.
    /// </summary>
    public static readonly string ChartFormatName = $"los_prop_{ChartVersion}";
    
    /// <inheritdoc />
    /// <remarks>If the <paramref name="source"/> is not a TOML string with the type of <see cref="ChartData"/> it will return <c>null</c></remarks>
    public ChartData Adapt(string source)
    {
        if (!Toml.TryToModel(source, out ChartData? chartData, out var diagnostics))
        {
            // TODO bruh
            // so instead of silently crashing, output the diagnostics to the console since ive been wondering wtf was going on for the past hour
            Console.WriteLine(diagnostics.ToString());
            return null!;
        }

        return chartData;
    }

    /// <inheritdoc />
    public string Prepare<TSource>(TSource source)
    {
        return source switch
        {
            string str => str,
            Stream stream => new StreamReader(stream).ReadToEnd(),
            _ => throw new InvalidOperationException($"Cannot prepare source of type {source?.GetType()}")
        };
    }
}