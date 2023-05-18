using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private Enemy healthbarEnemy;
    //[SerializeField] private Enemy maxhealth;
    //[SerializeField] privat
    
    public int dmg;
    private void Start()
    {
        //currenthealth = maxhealth;
        //healthbarEnemy.updateHealthbar(maxhealth, currenthealth);
    }

    private void OnMouseDown()
    {
        //currenthealth -= dmg;

       

    }


}
