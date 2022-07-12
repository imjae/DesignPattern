using System;

namespace HeadFirst.Assets.Scripts.Chapter02.Chapter02_observer
{
    public class WeatherData : Subject
    {
        // 인스턴스 변수 선언
        List<Observer> observers;
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            observers.ForEach(observer =>
            {
                observer.Update();
            });
        }



        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}