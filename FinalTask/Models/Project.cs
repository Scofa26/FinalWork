using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Summary { get; set; }
        public string? DefaultAccess { get; set; }
    }
}
