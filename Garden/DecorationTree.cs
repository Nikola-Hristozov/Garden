using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public abstract class DecorationTree : Tree, IBeauty
    {
        public double BeautyScore { get; set; }
        protected DecorationTree(double beautyScore,double waterRequiered)
        {
            this.BeautyScore = beautyScore;
            this.WaterRequiered = waterRequiered;
        }
    }
}
