using System;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new NormalQuack();
        }

        public override string Display()
        {
            return "Hi, I am Mallard duck.";
        }
    }
}