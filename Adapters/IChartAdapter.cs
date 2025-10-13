using LivinOnSweets.ChartFormat.Models;

namespace LivinOnSweets.ChartFormat.Adapters;

/// <summary>
/// Interface which is used to adapt an object type into <see cref="ChartData"/>
/// </summary>
public interface IChartAdapter
{
    /// <summary>
    /// Prepares the <paramref name="source"/> for consumption in <see cref="Adapt"/>.
    /// </summary>
    /// <param name="source">The untyped object to prepare.</param>
    /// <returns>A prepared object to be casted or used inside <see cref="Adapt"/>.</returns>
    object? Prepare(object source);
    
    /// <summary>
    /// Called when trying to retrieve the chart type of an untyped object type.
    /// </summary>
    /// <param name="source">The untyped source to convert.</param>
    /// <returns>An adapted <see cref="ChartData"/>.</returns>
    ChartData? Adapt(object source);
}

/// <summary>
/// Interface which is used to adapt <typeparamref name="TExternal"/> into <see cref="ChartData"/>.
/// </summary>
/// <typeparam name="TExternal">The source type to adapt from into a <see cref="ChartData"/>.</typeparam>
public interface IChartAdapter<TExternal> : IChartAdapter
{
    /// <summary>
    /// Prepares the raw input into a typed object.
    /// </summary>
    /// <typeparam name="TSource">The expected type of the raw input (often <see cref="string"/>).</typeparam>
    /// <param name="source">The raw input to prepare.</param>
    /// <returns>The prepared <typeparamref name="TExternal"/> object.</returns>
    TExternal? Prepare<TSource>(TSource source);
    
    /// <summary>
    /// Called when trying to retrieve the a chart type of <typeparamref name="TExternal"/>.
    /// </summary>
    /// <param name="source">The source chart of type <typeparamref name="TExternal"/>.</param>
    /// <returns>An adapted <see cref="ChartData"/>.</returns>
    ChartData? Adapt(TExternal source);
    
    object? IChartAdapter.Prepare(object source) => Prepare(source);
    
    /// <inheritdoc />
    /// <exception cref="InvalidCastException">Throws when <paramref name="source"/> can't be casted into <typeparamref name="TExternal"/></exception>
    ChartData? IChartAdapter.Adapt(object source)
    {
        if (source is not TExternal casted)
            throw new InvalidCastException($"Adapter expected {typeof(TExternal)}, got {source.GetType()}");
            
        return Adapt(casted);
    }
}

