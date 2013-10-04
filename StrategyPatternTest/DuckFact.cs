using StrategyPattern;
using Xunit;

namespace StrategyPatternTest
{
    public class DuckFact
    {
        [Fact]
        public void should_get_Quack_method_from_super_class()
        {
            var mallardDuck = new MallardDuck();
            Assert.Equal("gua gua gua!!!", mallardDuck.Quack());

            var redheadDuck = new RedheadDuck();
            Assert.Equal("gua gua gua!!!", redheadDuck.Quack());

            var rubberduck = new Rubberduck();
            Assert.Equal("cheep cheep cheep", rubberduck.Quack());
        }

        [Fact]
        public void should_get_Swim_method_from_super_class()
        {
            var mallardDuck = new MallardDuck();
            Assert.Equal("Yahoo~ The water is so cold~~", mallardDuck.Swim());

            var redheadDuck = new RedheadDuck();
            Assert.Equal("Yahoo~ The water is so cold~~", redheadDuck.Swim());

            var rubberduck = new Rubberduck();
            Assert.Equal("Yahoo~ The water is so cold~~", rubberduck.Swim());
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

//        [Fact]
//        public void should_return_fly_wings_for_MallardDuck_and_RedHeadDuck()
//        {
//            var mallardDuck = new MallardDuck();
//            Assert.Equal("I'm flying with my wings.", mallardDuck.PerformFly());
//
//            var redheadDuck = new RedheadDuck();
//            Assert.Equal("I'm flying with my wings.", redheadDuck.PerformFly());
//        }
//
//        [Fact]
//        public void should_return_can_not_fly_for_RubberDuck()
//        {
//            var rubberduck = new Rubberduck();
//            Assert.Equal("I cannot fly.", rubberduck.PerformFly());
//        }
    }
}
