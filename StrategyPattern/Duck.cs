namespace StrategyPattern
{
    public abstract class Duck
    {
        public virtual string Quack()
        {
            return "gua gua gua!!!";
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