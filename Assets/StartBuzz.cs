using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Headfirst.Chapter03
{
    public class StartBuzz : MonoBehaviour
    {
        Beverage beverage;

        // Start is called before the first frame update
        void Start()
        {
            beverage = new Espresso();
            Debug.Log($"{beverage.GetDescription()} ${beverage.Cost()}");

            
        }
    }
}
