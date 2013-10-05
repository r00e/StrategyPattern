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
            Assert.Equal("Hi, I am Mallard duck. WTF!!! I have a green head!!!", mallardDuck.Display());
        }

        [Fact]
        public void test_action_of_RedHeadDuck()
        {
            var redheadDuck = new RedheadDuck();
            
            Assert.Equal("gua gua gua!!!", redheadDuck.Quack());
            Assert.Equal("Yahoo~ The water is so cold~~", redheadDuck.Swim());
            Assert.Equal("Hi I am red head duck. I have a red head~~ Haha, look at the dude who wears a green hat! He is so franks.", redheadDuck.Display());
        }

        [Fact]
        public void test_action_of_RubberDuck()
        {
            var rubberduck = new Rubberduck();
            
            Assert.Equal("cheep cheep cheep", rubberduck.Quack());
            Assert.Equal("Yahoo~ The water is so cold~~", rubberduck.Swim());
            Assert.Equal("I'm made of rubber.", rubberduck.Display());
        }

//        [Fact]
//        public void test_Fly_action()
//        {
//            var mallardDuck = new MallardDuck();
//            Assert.Equal("I'm flying with my wings.", mallardDuck.PerformFly());
//
//            var redheadDuck = new RedheadDuck();
//            Assert.Equal("I'm flying with my wings.", redheadDuck.PerformFly());
//
//            var rubberduck = new Rubberduck();
//            Assert.Equal("I cannot fly.", rubberduck.PerformFly());
//        }
    }
}
