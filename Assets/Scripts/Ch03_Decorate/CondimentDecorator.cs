namespace Headfirst.Chapter03
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;

        public new abstract string GetDescription();
    }
}
