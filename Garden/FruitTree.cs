using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public abstract class FruitTree : Tree, IFood
    {
        protected FruitTree(double energy, double waterRequiered)
        {
            this.Energy = energy;
            this.WaterRequiered = waterRequiered;
        }
        public double Energy { get ; set; }
    }
}
