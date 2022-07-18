using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Headfirst.Chapter03
{
    public class StartBuzz : MonoBehaviour
    {
        public Beverage beverage;
        public Beverage beverage2;

        // Start is called before the first frame update
        void Start()
        {
            beverage = new Espresso();
            Debug.Log($"{beverage.GetDescription()} ${beverage.Cost()}");

            beverage2 = new HouseBlend();
            Debug.Log($"{beverage2.GetDescription()} ${beverage2.Cost()}");
            beverage2 = new Mocha(beverage2);
            Debug.Log($"{beverage2.GetDescription()} ${beverage2.Cost()}");
            beverage2 = new Mocha(beverage2);
            Debug.Log($"{beverage2.GetDescription()} ${beverage2.Cost()}");
            beverage2 = new Whip(beverage2);
            Debug.Log($"{beverage2.GetDescription()} ${beverage2.Cost()}");
        }
    }
}
