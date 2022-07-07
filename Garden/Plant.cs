using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public abstract class Plant : IGardenItem
    {
        public double WaterRequiered { get; set; }
    }
}
