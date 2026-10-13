using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProekt
{
   public class Controller
    {
        Model model = new Model();
        Display display = new Display();
        
        public void Start()
        { 
            display.Input();

            model.Kgzel = display.Kgzel;
            model.Kgplod = display.Kgplod;
            model.Kgzprice = display.Kgzprice;
            model.Kgpprice = display.Kgpprice;

            display.Total = model.Total();

            display.Output();
        }
    }
}
