using Newtonsoft.Json;

namespace LivinOnSweets.ChartFormat.Models.Original;

/// <summary>
/// The structure of a beat highlight inside the JSON file
/// </summary>
public struct JsonBeatHighlight
{
    /// <summary>
    /// The starting beat of this highlight
    /// </summary>
    [JsonProperty("startBeat")]
    public int StartBeat;
    
    /// <summary>
    /// The last beat of this highlight
    /// </summary>
    [JsonProperty("endBeat")]
    public int EndBeat;

    /// <summary>
    /// The amount of grids (steps) per beat inside this highlight
    /// </summary>
    [JsonProperty("beatHighlight")]
    public int Interval;
}