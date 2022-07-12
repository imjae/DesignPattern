using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Headfirst.Chapter01;

public class GameManager : MonoBehaviour
{
    MallardDuck mallardDuck = new MallardDuck();
    RedheadDuck redheadDuck = new RedheadDuck();
    RubberDuck rubberDuck = new RubberDuck();

    // Start is called before the first frame update
    void Start()
    {
        mallardDuck.PerformQuack();
        redheadDuck.PerformQuack();
        rubberDuck.PerformQuack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
