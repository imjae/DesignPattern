namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public interface Subject
    {
        public void RegisterObserver(Observer observer);
        public void RemoveObserver(Observer observer);
        public void NotifyObserver();
    }
}