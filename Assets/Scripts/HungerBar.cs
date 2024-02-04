using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    [SerializeField] Image healthbarSprite;


    public void UpdateHungerBar(float minHunger, float currentHunger)
    {
        healthbarSprite.fillAmount = currentHunger / minHunger;
    }

}
