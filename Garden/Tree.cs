using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public abstract class Tree : IGardenItem
    {
        public double WaterRequiered { get; set; }
    }
}
