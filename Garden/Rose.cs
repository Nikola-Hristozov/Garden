using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Rose: Flower
    {
        public Rose() : base(15, 5)
        {
        }
        public Rose(double beautyScore, double waterRequiered) : base(beautyScore, waterRequiered)
        {
        }
    }
}
