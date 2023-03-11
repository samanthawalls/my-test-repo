using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Shirt : Clothing
    {
        public string Size { get; set; }
        public string SleeveType { get; set; }
        public bool IsCollared { get; set; }
        public bool HasButtons { get; set; }
        public Shirt() 
        {
            Size = string.Empty;
            SleeveType = string.Empty;
        }
    }
}
