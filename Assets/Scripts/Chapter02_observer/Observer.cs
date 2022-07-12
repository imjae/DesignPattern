namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public interface Observer
    {
        public void Update(float temp, float humidity, float pressure);
    }
}