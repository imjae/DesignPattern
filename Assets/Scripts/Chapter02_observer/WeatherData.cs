using System;
using System.Collections.Generic;

using UnityEngine;

namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public class WeatherData : MonoBehaviour, Subject
    {
        // 인스턴스 변수 선언
        private List<Observer> observers;
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        private void Awake()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer observer)
        {
            Debug.Log("@@");
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
                observer.UpdateData(Temperature, Humidity, Pressure);
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