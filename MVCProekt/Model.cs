using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProekt
{
    public class Model
    {
        private int kgzel;
        public int Kgzel
        {
            get { return kgzel; }
            set { kgzel = value; }
        }
        private int kgplod;
        public int Kgplod
        {
            get { return kgplod; }
            set { kgplod = value; }
        }
        private double kgzprice;
        public double Kgzprice
        {
            get { return kgzprice; }
            set { kgzprice = value; }
        }
        private double kgpprice;
        public double Kgpprice
        {
            get { return kgpprice; }
            set { kgpprice = value; }
        }
        public double CalcFruit()
        {
            return Kgplod * Kgpprice;
        }
        public double CalcVegetable()
        {
            return Kgzel * Kgzprice;
        }
        public double Total()
        {
            return (CalcFruit() + CalcVegetable()) / 1.94;
        }
    }
}
