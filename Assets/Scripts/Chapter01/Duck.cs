namespace Headfirst.Chapter01
{
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

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

        protected virtual void Swim() { }
        protected virtual void Display() { }

    }
}