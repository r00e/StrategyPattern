using System;

namespace StrategyPattern
{
    public class Rubberduck : Duck
    {
        public override string Display()
        {
            return "I'm made of rubber.";
        }

        public new string Quack()
        {
            return "cheep cheep cheep";
        }

        public new string Fly()
        {
            return "I cannot fly.";
        }

        public new string Swim()
        {
            return "swim like a shark";
        }
    }
}