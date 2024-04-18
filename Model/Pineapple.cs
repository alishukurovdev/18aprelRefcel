using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahindiBratva.Model
{
     class Pineapple:Fruit
    {
        public Pineapple(decimal price, string sort, int vitaminE, int vitaminD) : base(price, sort)
        {
            this.VitaminD = vitaminD;
            this.VitaminE = vitaminE;
        }

        public int VitaminE { get; set; }
        public int VitaminD { get; set; }
       
        public override void Taste()
        {
            Console.WriteLine("keskin dadli");}
        
    }
}
