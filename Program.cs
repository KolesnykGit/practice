using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ranch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Farmer
            Farmer farmer = new Farmer("Ben");

            farmer.Chill();

            farmer.Eat(new HumanFood());

            farmer.Sleep();
            #endregion
            
            #region Pig
            Pig pig = new Pig();

            pig.Voice();
                
            pig.Eat(new PigFeed());
            #endregion

            #region Boozer
            Boozer boozer = new Boozer();

            boozer.Voice();

            boozer.Eat(new BoozerVodka());
            #endregion

            Console.ReadKey();
            
        }
    }
}