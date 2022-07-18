namespace Headfirst.Chapter03
{
    public abstract class CondimentDecorator : Beverage
    {
        Beverage beverage;

        public new abstract string GetDescription();
    }
}
