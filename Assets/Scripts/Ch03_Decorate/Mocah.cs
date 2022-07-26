namespace Headfirst.Chapter03.remind1
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocah";
        }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
}
