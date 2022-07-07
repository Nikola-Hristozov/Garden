using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public abstract class Flower : Plant, IBeauty
    {
        public double BeautyScore { get; set; }
        protected Flower(double beautyScore, double waterRequiered)
        {
            this.BeautyScore = beautyScore;
            this.WaterRequiered = waterRequiered;
        }
    }
}
