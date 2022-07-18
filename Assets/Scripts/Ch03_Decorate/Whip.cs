namespace Headfirst.Chapter03
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", 휘핑크림";
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
}
