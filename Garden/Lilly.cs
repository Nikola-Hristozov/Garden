using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Lilly : Flower
    {
        public Lilly() : base(7, 2) 
        {
        }
        public Lilly(double beautyScore, double waterRequiered) : base(beautyScore, waterRequiered)
        {
        }
    }
}
