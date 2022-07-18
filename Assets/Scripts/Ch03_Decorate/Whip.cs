namespace Headfirst.Chapter03
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 휘핑크림";
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
}
