using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steak : FoodController
{
    //Inheritance
    public override void UpdateCurrentHunger()
    {
        playerController._currentHunger += 0.3f;
    }
    //Polymorphism
}
