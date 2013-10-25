namespace StrategyPattern
{
    public class NormalQuack : IQuackBehavior
    {
        public string PerformQuack()
        {
            return "gua gua gua!!!";
        }
    }
}