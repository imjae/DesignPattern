namespace Headfirst.Chapter03.remind1
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public override string GetDescription()
        {
            return base.GetDescription();
        }
    }
}
