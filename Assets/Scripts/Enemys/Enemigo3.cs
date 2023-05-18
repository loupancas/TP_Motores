using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : Enemy
{
    
    [SerializeField] GameObject character;
    [SerializeField] bullet bullet;
    [SerializeField] float shotspeed;
    [SerializeField] float time;
    [SerializeField] float rangeAttack;
    public int cantidadDmg = 10;
    //Player player;
    private void Update()
    {
        Attack();
    }
    public GameObject projectile;
    protected override void introduction()
    {
        //base.introduction();
        Debug.Log("Hola, este es el enemigo 3");
    }

    protected override void Attack()
    {
        //base.Attack();
        transform.forward = character.transform.position - transform.position;
        if (time > 0) time -= Time.deltaTime;
        if(time<=0)
        {
            if (character != null)
            {
                bullet newbullet = Instantiate(bullet, transform.position, Quaternion.identity);
                newbullet.transform.localPosition = transform.position;
                newbullet.transform.rotation = transform.rotation;
                //player.GetComponent<Player>().TakeDamage(cantidadDmg);
            }
            time = shotspeed;
        }
        
    }





}
