using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : Enemy, IEnemyAttack
{
    private float moveRate = 2f;
    private float moveTimer;
    [SerializeField] private float minX, maxX, minY, maxY;
    public int cantidadDmg = 20;
    protected override void introduction()
    {
        //base.introduction();
        Debug.Log("Hola, este es el enemigo 2");
    }

    protected override void Move()
    {
        //base.Move();

        RandomMove();

    }

    void IEnemyAttack.Attack()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                other.GetComponent<Player>().TakeDamage(cantidadDmg);

                Debug.Log("ataque");

            }

        }
    }

    private void RandomMove()
    {
        moveTimer += Time.deltaTime;

        if(moveTimer>moveRate)
        {
            transform.position = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minY, maxY));
            moveTimer = 0;
        }
    }




}
