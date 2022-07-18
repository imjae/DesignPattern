namespace Headfirst.Chapter03
{
    public abstract class Beverage
    {
        string description = "no title";
        
        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
