using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField] float lifetime;
    [SerializeField] float speed;
    public LayerMask playerMask;
    public bool isEnemyBullet;
    public int damage;

    private void Update()
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        lifetime -= Time.deltaTime;
        //if (lifetime <= 0) Destroy(gameObject);
        if (lifetime <= 0) gameObject.SetActive(false);
    }

    

    private void OnTriggerEnter(Collider collision) // las bullets se destruiran cuando colisionen con otros objetos que tengan collider, recordar que deben tener RigidBody
    {
        var damageable = collision.GetComponent<IBulletDamage>();

        if(isEnemyBullet)
        {
            //var player = (Player)damageable; // convierte a player

            if(damageable is Player)
            {
                var player = (Player)damageable;

                if (player != null)
                {
                    if (damageable != null)
                    {
                        damageable.BulletDmg(damage);
                    }

                }
            }

             

          
        }
        else
        {
            var enemy = (Enemy)damageable; // convierte a Enemy
            if (enemy != null)
            {
                if (damageable != null)
                {
                    damageable.BulletDmg(damage);
                }

            }

        }/////






        //var B = collision.gameObject.GetComponent<bullet>();

        //if (B != null) // si choca un bullet con otro sale de la funci�n y no lo elimina
        //{
        //    return;
        //}

        //if (!isEnemyBullet)
        //{
        //    Enemy Rompible = collision.gameObject.GetComponent<Enemy>(); // esta trayendo el codigo 


        //    if (Rompible)
        //    {
        //        Debug.Log("el da�o realizado es" + damage);
        //        Rompible.golpe(damage); // llama a la funcion golpe del otro script

        //    }

        //    if (collision.gameObject.tag != "Player") // se destruir� con todo lo que no sea el PJ o sea los enemigos
        //    {

        //        Destroy(gameObject);

        //    }
        //}




    }

}
