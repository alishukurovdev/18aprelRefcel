using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahindiBratva.Model
{
     class Apple: Fruit
    {
        public Apple(decimal price, string sort, int vitaminA, int vitaminB) : base(price, sort)
        {
               this.VitaminA= vitaminA;
               this.VitaminB= vitaminB;
        }

        public int VitaminA { get; set; }
        public int VitaminB { get; set; }
        
        

        public override void Taste()
        {
            Console.WriteLine("Tursh alma");
        }
    }
}
