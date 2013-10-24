using StrategyPattern;
using Xunit;

namespace StrategyPatternTest
{
    public class DuckFact
    {
        [Fact]
        public void test_action_of_MallardDuck()
        {
            var mallardDuck = new MallardDuck();

            Assert.Equal("gua gua gua!!!", mallardDuck.Quack());
            Assert.Equal("Yahoo~ The water is so cold~~", mallardDuck.Swim());
            Assert.Equal("Hi, I am Mallard duck.", mallardDuck.Display());
        }

        [Fact]
        public void test_action_of_RedHeadDuck()
        {
            var redheadDuck = new RedheadDuck();

            Assert.Equal("red head gua", redheadDuck.Quack());
            Assert.Equal("swim like a shark", redheadDuck.Swim());
            Assert.Equal("Hi I am red head duck.", redheadDuck.Display());
        }

        [Fact]
        public void test_action_of_RubberDuck()
        {
            var rubberduck = new Rubberduck();
            
            Assert.Equal("cheep cheep cheep", rubberduck.Quack());
            Assert.Equal("swim like a shark", rubberduck.Swim());
            Assert.Equal("I'm made of rubber.", rubberduck.Display());
        }

        [Fact]
        public void test_Fly_action()
        {
            var mallardDuck = new MallardDuck();
            Assert.Equal("I'm flying with my wings.", mallardDuck.Fly());

            var redheadDuck = new RedheadDuck();
            Assert.Equal("I'm flying with my wings.", redheadDuck.Fly());

            var rubberduck = new Rubberduck();
            Assert.Equal("I cannot fly.", rubberduck.Fly());
        }
    }
}
