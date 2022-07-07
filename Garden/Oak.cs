using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Oak : DecorationTree
    {
        public Oak():base(5,11)
        {
        }
        public Oak(double beautyScore, double waterRequiered):base(beautyScore,waterRequiered)
        {
        }
    }
}
