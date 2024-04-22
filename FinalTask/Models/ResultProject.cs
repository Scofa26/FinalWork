using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class ResultProject
    {
        [JsonPropertyName("result")] public Project Projects { get; set; }
        [JsonPropertyName("expands")] public List<Expands> Expands { get; set; }
    }
}
