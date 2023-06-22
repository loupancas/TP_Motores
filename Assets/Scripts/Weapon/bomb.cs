using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    Rigidbody rgb;
    [SerializeField] float throwForce = 5f;
    public bool isEnemyBomb;
    public int damage;
    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();

    }

    public void throwBomb(Vector3 pos,Vector3 dir)
    {
        this.transform.position = pos;
        rgb.AddForce(dir *throwForce,ForceMode.VelocityChange);
        Destroy(this.gameObject, 2f);
    }

    private void OnTriggerEnter(Collider collision) // las bullets se destruiran cuando colisionen con otros objetos que tengan collider, recordar que deben tener RigidBody
    {
        var damageable = collision.GetComponent<IBulletDamage>();

        if (isEnemyBomb)
        {
            //var player = (Player)damageable; // convierte a player

            if (damageable is Player)
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

        }




    }

}
