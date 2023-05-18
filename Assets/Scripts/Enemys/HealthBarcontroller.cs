using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarcontroller : MonoBehaviour
{
    [SerializeField] private Image healthbarsprite;
    
    public void updateHealthbar(float maxhealth,float currenthealth)
    {
        healthbarsprite.fillAmount = currenthealth / maxhealth;

    }


}
