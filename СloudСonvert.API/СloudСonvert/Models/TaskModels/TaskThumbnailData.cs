using Newtonsoft.Json;
using СloudСonvert.API.СloudСonvert.Models.Enums;

namespace СloudСonvert.API.СloudСonvert.Models.TaskModels
{
  public class TaskThumbnailData : Base
  {
    /// <summary>
    /// The input task name(s) for this task.
    /// input: string | string[];
    /// </summary>
    [JsonProperty("input")]
    public dynamic Input { get; set; }

    /// <summary>
    /// If not set, the extension of the input file is used as input format
    /// </summary>
    [JsonProperty("input_format", NullValueHandling = NullValueHandling.Ignore)]
    public string Input_Format { get; set; }

    [JsonProperty("output_format")]
    public OutputFormatThumbnail Output_Format { get; set; }

    [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
    public string Engine { get; set; }

    [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
    public string Engine_Version { get; set; }

    /// <summary>
    /// Choose a filename (including extension) for the output file.
    /// </summary>
    [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
    public string Filename { get; set; }

    /// <summary>
    /// Timeout in seconds after the task will be cancelled.
    /// </summary>
    [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
    public int? Timeout { get; set; }
  }
}
