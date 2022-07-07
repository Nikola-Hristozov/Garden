using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Apricot : FruitTree
    {
        public Apricot():base(7,7)
        {
        }

        public Apricot(double energy, double waterRequiered) : base(energy, waterRequiered)
        {
        }
    }
}
