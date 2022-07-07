using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Garden
    {
        private List<IGardenItem> gardenItems=new List<IGardenItem>();
        private List<IGardenItem> GardenItems { get => gardenItems; set => gardenItems = value; }
        public List<IFood> Foods { 
            get
            {
                return GardenItems.Where(x => (x as IFood) != null).Select(x=>(x as IFood)).ToList();
            }
        }
        public List<IBeauty> Beauty
        {
            get
            {
                return GardenItems.Where(x => (x as IBeauty)!=null).Select(x => (x as IBeauty)).ToList();
            }
        }
        public void Add(string type, int count, int otherParam, int waterRequerment)
        {
            IGardenItem gardenItem = null;
            switch (type)
            {
                case "rose":
                    {
                        gardenItem = new Rose(otherParam, waterRequerment);
                        break;
                    }
                case "apricot":
                    {
                        gardenItem = new Apricot(otherParam, waterRequerment);
                        break;
                    }
                case "lilly":
                    {
                        gardenItem = new Lilly(otherParam, waterRequerment);
                        break;
                    }
                case "peach":
                    {
                        gardenItem = new Peach(otherParam, waterRequerment);
                        break;
                    }
                case "oak":
                    {
                        gardenItem = new Oak(otherParam, waterRequerment);
                        break;
                    }
                case "acacia":
                    {
                        gardenItem = new Acacia(otherParam, waterRequerment);
                        break;
                    }
                case "strawberry":
                    {
                        gardenItem = new Strawberry(otherParam, waterRequerment);
                        break;
                    }
                case "carotte":
                    {
                        gardenItem = new Carotte(otherParam, waterRequerment);
                        break;
                    }
                default:
                    break;
            }
            if (gardenItem != null)
                for (int i = 0; i < count; i++)
                {
                    GardenItems.Add(gardenItem);
                }
        }
        public void Add(string type,int count)
        {
            IGardenItem gardenItem=null;
            switch (type)
            {
                case "rose":
                    {
                        gardenItem = new Rose();
                        break;
                    }
                case "apricot":
                    {
                        gardenItem = new Apricot();
                        break;
                    }
                case "lilly":
                    {
                        gardenItem = new Lilly();
                        break;
                    }
                case "peach":
                    {
                        gardenItem = new Peach();
                        break;
                    }
                case "oak":
                    {
                        gardenItem = new Oak();
                        break;
                    }
                case "acacia":
                    {
                        gardenItem = new Acacia();
                        break;
                    }
                case "strawberry":
                    {
                        gardenItem = new Strawberry();
                        break;
                    }
                case "carotte":
                    {
                        gardenItem = new Carotte();
                        break;
                    }
                default:
                    break;
            }
            if(gardenItem!=null)
                for (int i = 0; i < count; i++)
                {
                    GardenItems.Add(gardenItem);
                }
            
        }

        public double getWaterRequiered()
        {
            return GardenItems.Select(x => x.WaterRequiered).Sum();
        }
        public double getEnergy()
        {
            if (Foods != null)
                return Foods.Select(x => x.Energy).Sum();
            else return 0;
        }
        public double getBeautyScore()
        {
            if (Beauty != null)
                 return Beauty.Select(x => x.BeautyScore).Sum();
            else return 0;
        }
        public override string ToString()
        {
            return "\nBeauty Score: "+getBeautyScore()+"\nWater Requiered: "+getWaterRequiered()+"\nEnergy:"+getEnergy();
        }
    }
}
