using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : Main_damage
{
    
    public bool invencible=false;
    public float tiempo_invencible = 1f;
    public float tiempo_frenado = 0.2f;


    protected override void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Player>()!=null)
        {
            StartCoroutine(Damage(other.GetComponent<Player>()));
          

        }

        

    }

    protected override void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            StopAllCoroutines();

        }
    }


    IEnumerator Damage(Player player)
    {
        while(true)
        {
            player.TakeDamage(cantidadDmg);
            yield return new WaitForSeconds(tiempo_invencible);
        }
        
       

    }

    IEnumerator frenaVelocidad()
    {
        var vel = GetComponent<Movement>().speed;
        GetComponent<Movement>().speed = 0;
        yield return new WaitForSeconds(tiempo_frenado);
        GetComponent<Movement>().speed = vel;
    }



}
