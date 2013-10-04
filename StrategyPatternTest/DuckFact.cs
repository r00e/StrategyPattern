using StrategyPattern;
using Xunit;
using Xunit.Extensions;

namespace StrategyPatternTest
{
    public class DuckFact
    {
        private const string Quack = "gua gua gua!!!";
        private const string QuackForRubberduck = "cheep cheep cheep";
        private const string Swim = "Yahoo~ The water is so cold~~";

        [Fact]
        public void should_get_Quack_method_from_super_class()
        {
            var mallardDuck = new MallardDuck();
            Assert.Equal(Quack, mallardDuck.Quack());

            var redheadDuck = new RedheadDuck();
            Assert.Equal(Quack, redheadDuck.Quack());

            var rubberduck = new Rubberduck();
            Assert.Equal(QuackForRubberduck, rubberduck.Quack());
        }

        [Fact]
        public void should_get_Swim_method_from_super_class()
        {
            var mallardDuck = new MallardDuck();
            Assert.Equal(Swim, mallardDuck.Swim());

            var redheadDuck = new RedheadDuck();
            Assert.Equal(Swim, redheadDuck.Swim());

            var rubberduck = new Rubberduck();
            Assert.Equal(Swim, rubberduck.Swim());
        }

        [Fact]
        public void should_return_green_head_for_MallardDuck()
        {
            var mallardDuck = new MallardDuck();
            Assert.Contains("green", mallardDuck.Display());
        }

        [Fact]
        public void should_return_red_head_for_RedHeadDuck()
        {
            var redheadDuck = new RedheadDuck();
            Assert.Contains("red", redheadDuck.Display());
        }

        [Fact]
        public void should_return_rubber_for_rubberDuck()
        {
            var rubberduck = new Rubberduck();
            Assert.Contains("rubber", rubberduck.Display());
        }
    }
}
