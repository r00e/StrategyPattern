namespace StrategyPattern
{
    public class CheepQuack : IQuackBehavior
    {
        public string PerformQuack()
        {
            return "cheep cheep cheep";
        }
    }
}