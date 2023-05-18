using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : Enemy
{
    private float moveRate = 2f;
    private float moveTimer;
    [SerializeField] private float minX, maxX, minY, maxY;
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
