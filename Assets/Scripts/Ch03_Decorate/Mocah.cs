namespace Headfirst.Chapter03
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", 모카";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .20;
        }
    }
}
