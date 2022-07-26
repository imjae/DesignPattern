namespace Headfirst.Chapter03
{
    public abstract class Beverage
    {
        public string description = "no title";
        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
