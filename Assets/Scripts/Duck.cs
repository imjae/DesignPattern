

public abstract class Duck
{
    public FlyBehavior flyBehavior;
    public QuackBehavior quackBehavior;

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    protected virtual void Swim(){}
    protected virtual void Display(){}

}
