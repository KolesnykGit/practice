using System.Deployment.Internal;

namespace Ranch
{
    internal interface IHuman
    {
        string Name { get; set; }
        FoodList Food { get; }
        void Chill();
        void Sleep();
        void Eat(Food food);
    }
}