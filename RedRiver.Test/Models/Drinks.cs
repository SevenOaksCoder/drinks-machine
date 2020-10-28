using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedRiver.Test.Models
{
    public class Drinks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string OutOfOrder { get; set; }
        public List<string> Recipe { get; set; } = new List<string>();
    }
}
