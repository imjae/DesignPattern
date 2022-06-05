public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        quackBehavior = new Squeak();
        flyBehavior = new FlyWithWings();
    }

    protected override void Display()
    {
        // 적당한 모양을 표시
    }
}
