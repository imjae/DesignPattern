using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Headfirst.Chapter03.remind1
{
    public class StartBuzz : MonoBehaviour
    {
        public Beverage beverage;
        public Beverage beverage2;

        // Start is called before the first frame update
        void Start()
        {
            Beverage beverage = new Espresso();

            Debug.Log($"{beverage.GetDescription()} $ {beverage.Cost()}");

            beverage = new Mocha(beverage);
            Debug.Log($"{beverage.GetDescription()} $ {beverage.Cost()}");
        }
    }
}
