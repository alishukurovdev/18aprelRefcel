using SahindiBratva.Model;

namespace SahindiBratva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(3, "alma", 44, 42);
            Pineapple pineapple = new Pineapple(4,"yerli",44,42);
            Orange orange = new Orange(4, "kent", 44);

            Fruit[] BasketMenyu = {apple,pineapple, orange};
            foreach(var fruit in BasketMenyu)
            {
                //if(fruit is Apple app)
                //{
                //    Console.WriteLine($"sortu {app.Sort} qiymeti {app.Price}manat vitaminA {app.VitaminA}% VitaminB {app.VitaminB}%");
                //}else if(fruit is Pineapple papp)
                //{
                //    Console.WriteLine($"sortu {papp.Sort} qiymeti {papp.Price}manat vitaminE {papp.VitaminE}% VitaminD {papp.VitaminD}%");
                //}
                //else if(fruit is Orange org)
                //{
                //    Console.WriteLine($"sortu {org.Sort} qiymeti {org.Price}manat vitaminC {org.VitaminC}% ");
                //}
                var type=fruit.GetType();
                Console.WriteLine(type.Name);
                foreach (var item in type.GetFields())
                {
                    Console.WriteLine(item.GetValue(fruit));

                
                }
            }
            

        }
    }
}