namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public interface Subject
    {
        public void RegisterObserver();
        public void RemoveObserver();
        public void NotifyObserver();
    }
}