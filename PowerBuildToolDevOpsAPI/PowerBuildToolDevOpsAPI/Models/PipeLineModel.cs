using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBuildToolDevOpsAPI.Models
{
    public class PipeLineModel
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }
    }
}
