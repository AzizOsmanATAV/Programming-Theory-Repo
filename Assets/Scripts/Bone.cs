using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : FoodController
{
    //Inheritance


    public override void UpdateCurrentHunger()
    {
        playerController._currentHunger +=  0.1f;
    }
    //Polymorphism

}
