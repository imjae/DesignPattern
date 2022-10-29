namespace Headfirst.Chapter03.remind1
{
    public class Mocha : CondimentDecorator
    {
        new Beverage beverage;
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
            return this.beverage.Cost() + .20;
        }
    }
}
