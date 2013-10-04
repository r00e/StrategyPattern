namespace StrategyPattern
{
    public abstract class Duck
    {
        public string Quack()
        {
            return "gua gua gua!!!";
        }

        public string Swim()
        {
            return "Yahoo~ The water is so cold~~";
        }

        public abstract string Display();

        public string Fly()
        {
            return "I am flying!! Look the ants on the ground!!";
        }
    }
}