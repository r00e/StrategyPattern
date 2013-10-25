using System;

namespace StrategyPattern
{
    public class RedheadDuck : Duck
    {
        public override string Display()
        {
            return "Hi I am red head duck.";
        }

        public new string Swim()
        {
            return "swim like a shark";
        }
    }
}