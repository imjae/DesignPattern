using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public class StatisticsDisplay : MonoBehaviour, Observer, DisplayElement
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private List<Observer> observers;
        public WeatherData weatherData;

        private List<float> history;

        private void Start()
        {
            history = new List<float>();
            weatherData.RegisterObserver(this);
        }

        public void UpdateData(float temp, float humidity, float pressrue)
        {
            Temperature = temp;
            Humidity = humidity;

            history.Add(Temperature);

            Display();

        }

        public void Display()
        {
            Debug.Log($"평균/최고/최저 온도 = {history.Average()}/{history.Max()}/{history.Min()}");
        }
    }
}