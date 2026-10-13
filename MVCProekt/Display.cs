using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProekt
{
    public class Display
    {
        public int Kgzel { get; set; }
        public int Kgplod { get; set; }
        public double Kgzprice { get; set; }
        public double Kgpprice { get; set; }

        public double Total { get; set; }

        public void Input()
        {
            Console.Write("Ведете цена за килограм зеленчуци: ");
            Kgzprice = double.Parse(Console.ReadLine());
            Console.Write("Ведете цена за килограм плодове: ");
            Kgpprice = double.Parse(Console.ReadLine());
            Console.Write("Ведете количество килограми зеленчуци: ");
            Kgzel = int.Parse(Console.ReadLine());
            Console.Write("Ведете количество килограми плодове :");
            Kgplod = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Цената е {Total} евро.");
        }
    }
}
