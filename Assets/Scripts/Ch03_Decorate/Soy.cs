namespace Headfirst.Chapter03
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", 두유";
        }

        public override double Cost()
        {
            return beverage.Cost() + .50;
        }
    }
}
