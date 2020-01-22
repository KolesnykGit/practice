using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranch
{
    internal abstract class Food
    {
        public abstract string Name { get; }
    }

    internal class PigFeed : Food
    {
        public override string Name => "Feed";
    }

    internal class BoozerVodka : Food
    {
        public override string Name => "Vodka";
    }

    internal class CowHey : Food
    {
        public override string Name => "Hey";
    }

    internal class HumanFood : Food
    {
        public override string Name => "Meat";
    }
}
