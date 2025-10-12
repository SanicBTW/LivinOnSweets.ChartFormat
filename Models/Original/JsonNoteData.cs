using Newtonsoft.Json;

namespace LivinOnSweets.ChartFormat.Models.Original;

/// <summary>
/// Represents a JSON note structure
/// </summary>
public struct JsonNoteData
{
    /// <summary>
    /// The type of this note, should and ONLY be "normal" or "long"
    /// </summary>
    [JsonProperty("type")]
    public string Type;

    /// <summary>
    /// The lane where this note belongs
    /// </summary>
    [JsonProperty("lane")]
    public int Lane;

    /// <summary>
    /// The beat this note is part of
    /// </summary>
    [JsonProperty("beat")]
    public int Beat;

    /// <summary>
    /// The grid (step) this note will spawn on
    /// </summary>
    [JsonProperty("grid")]
    public int Grid;

    /// <summary>
    /// The grids per beat this note should be in
    /// </summary>
    [JsonProperty("gridsPerBeat")]
    public int GridsPerBeat;

    /// <summary>
    /// If the note is fever grants more points
    /// </summary>
    [JsonProperty("fever")]
    public bool Fever;

    /// <summary>
    /// The ending beat of the note, only used when <see cref="Type"/> is "long" 
    /// </summary>
    [JsonProperty("endBeat")]
    public int? EndBeat;

    /// <summary>
    /// The ending grid (step) of the note, only used when <see cref="Type"/> is "long"
    /// </summary>
    [JsonProperty("endGrid")]
    public int? EndGrid;
}