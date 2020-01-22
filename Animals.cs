using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranch
{
    internal abstract class Animals
    {
        public string Name { get; set; }  
        public abstract void Voice();
        public abstract FoodList Food { get; }
        public abstract void Eat(Food food);    


    }
    internal class Pig : Animals
    {
        public override void Voice()
        {
            Console.WriteLine("HruHru");
        }

        public override FoodList Food => FoodList.PigFeed;

        public override void Eat(Food food) 
        {
            Console.WriteLine($"Pig eats {food.Name}");
        }
    }
    internal class Cow : Animals
    {
        public override void Voice()
        {
            Console.WriteLine("MuMu");
        }

        public override FoodList Food => FoodList.CowHay;

        public override void Eat(Food food)
        {
            Console.WriteLine($"Cow eats {food.Name}");
        }
    }
    internal class Boozer : Animals
    {
        public override void Voice()
        {
            Console.WriteLine("Kolyaaan give me VODKA");
        }

        public override FoodList Food => FoodList.BoozerVodka;

        public override void Eat(Food food)
        {
            Console.WriteLine($"Boozer loves {food.Name}");
        }
    }
}
