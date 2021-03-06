using System;
using System.Collections.Generic;
using UnityEngine;

namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public class CurrentConditionsDisplay : MonoBehaviour, Observer, DisplayElement
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        public WeatherData weatherData;

        private void Start()
        {
            weatherData.RegisterObserver(this);
        }

        public void UpdateData(float temp, float humidity, float pressrue)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Debug.Log($"현재 상태 : 온도 {Temperature}F, 습도 {Humidity}");
        }
    }
}