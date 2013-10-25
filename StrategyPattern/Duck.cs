namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;

        public virtual string Quack()
        {
            return quackBehavior.PerformQuack();
        }

        public virtual string Swim()
        {
            return "Yahoo~ The water is so cold~~";
        }

        public abstract string Display();

//        public string Fly()
//        {
//            return "I'm flying with my wings.";
//        }
    }
}