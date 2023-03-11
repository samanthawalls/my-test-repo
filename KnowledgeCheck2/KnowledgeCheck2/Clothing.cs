using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Clothing
    {
        public string Material { get; set; }
        public decimal Price { get; set; }
        public int  NumberInStock { get; set; }
        public Clothing()
        {
            
            Material = string.Empty;
        }
    }
}
