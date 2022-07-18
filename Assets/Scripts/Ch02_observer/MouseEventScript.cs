using System;
using UnityEngine;
using UnityEngine.UI;

namespace HeadFirst.Assets.Scripts.Chapter02_observer
{
    public class MouseEventScript : MonoBehaviour
    {
        public InputField tempField;
        public InputField humidityField;
        public InputField pressureField;
        // Start is called before the first frame update

        public WeatherData weatherData;
        public void OnClickSetButton()
        {
            weatherData.SetMeasurements(
                float.Parse(tempField.text),
                float.Parse(humidityField.text),
                float.Parse(pressureField.text)
            );
        }
    }
}