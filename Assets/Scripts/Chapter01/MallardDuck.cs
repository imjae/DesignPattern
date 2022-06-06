namespace Headfirst.Chapter01
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new StandardQuack();
            flyBehavior = new FlyWithWings();
        }

        protected override void Display()
        {
            // 적당한 모양을 표시
        }
    }
}