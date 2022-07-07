using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Acacia : DecorationTree
    {
        public Acacia():base(10,3)
        {
        }

        public Acacia(double beautyScore, double waterRequiered) : base(beautyScore, waterRequiered)
        {
        }
    }
}
