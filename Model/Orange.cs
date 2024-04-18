using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahindiBratva.Model
{
     class Orange:Fruit
    {
        public Orange(decimal price, string sort, int vitaminC) : base(price, sort)
        {
            this.VitaminC = vitaminC;
        }

        public int VitaminC { get; set; }
       
        public override void Taste()
        {
            Console.WriteLine("sirin dadli");        }
    }
}
