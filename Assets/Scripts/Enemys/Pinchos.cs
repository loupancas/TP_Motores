using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : Main_damage
{
    
    public bool invencible=false;
    public float tiempo_invencible = 1f;
    public float tiempo_frenado = 0.2f;
    protected override void OnTriggerStay(Collider other)
    {
        base.OnTriggerStay(other);

        if(this.tag=="pincho")
        {
            StartCoroutine(Invulnerabilidad());

            //StartCoroutine(frenaVelocidad());
        }


    }

    IEnumerator Invulnerabilidad()
    {
        invencible = true;
        yield return new WaitForSeconds(tiempo_invencible);
        invencible = false;

    }

    IEnumerator frenaVelocidad()
    {
        var vel = GetComponent<Movement>().speed;
        GetComponent<Movement>().speed = 0;
        yield return new WaitForSeconds(tiempo_frenado);
        GetComponent<Movement>().speed = vel;
    }



}
