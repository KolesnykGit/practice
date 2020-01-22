using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranch
{
    internal class Farmer : IHuman
    {
        public string Name { get; set; }
        public FoodList Food => FoodList.HumanFood;
        public Farmer(string name)
        {
            Name = name; 
        }
        
        public void Eat(Food food)
        {
            Console.WriteLine($"{Name} eats {food.Name} ");
        }

        public void Chill()
        {
            Console.WriteLine("Time for chill...");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping now");
        }       
    }
}
