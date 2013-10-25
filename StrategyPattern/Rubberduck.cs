namespace StrategyPattern
{
    public class Rubberduck : Duck
    {
        public override string Quack()
        {
            return new CheepQuack().PerformQuack();
        }

        public override string Swim()
        {
            return "swim like a shark";
        }

        public override string Display()
        {
            return "I'm made of rubber.";
        }

//        public new string Fly()
//        {
//            return "I cannot fly.";
//        }
    }
}