public class RubberDuck : Duck 
{
    public RubberDuck()
    {
        quackBehavior = new Squeak();
        flyBehavior = new FlyNoWay();
    }

    protected override void Display()
    {
        // 적당한 모양을 표시
    }
}
