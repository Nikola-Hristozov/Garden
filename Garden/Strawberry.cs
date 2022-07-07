using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Strawberry : EdiblePlant
    {
        public Strawberry():base(12,3)
        {
        }
        public Strawberry(double energy, double waterRequiered):base(energy,waterRequiered)
        {
        }
    }
}
