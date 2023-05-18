using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_damage : MonoBehaviour
{

    public int cantidadDmg = 10;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            other.GetComponent<Player>().TakeDamage(cantidadDmg);

            Debug.Log("ataque");

        }

    }

    protected virtual void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().TakeDamage(cantidadDmg);

            Debug.Log("ataque");

        }

    }




}
