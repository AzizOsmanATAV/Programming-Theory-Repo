using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : FoodController
{
    //Inheritance
    public override void UpdateCurrentHunger()
    {
        playerController._currentHunger += 0.2f;
    }
    //Polymorphism
}
