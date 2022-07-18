namespace Headfirst.Chapter03
{
    public abstract class Beverage
    {
        public string description = "no title";
        
        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
