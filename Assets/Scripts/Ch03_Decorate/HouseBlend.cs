namespace Headfirst.Chapter03
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
