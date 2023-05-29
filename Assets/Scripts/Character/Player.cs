using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities.LifeSystem;



public class Player : LifeEntity, IEnemyAttack, IBulletDamage
{

    public ManagerUI ManagerUI;
    

    protected override void Awake()
    {
       // base.Awake();//life = new Life(100);
    }
    protected override void OnInitialize()
    {
        GameManager.gameManager.SetPlayer(this); // se asigna a sí mismo
    }
    protected override void OnDeInitialize()
    {
        
    }

    protected override void OnFixedUpdate()
    {
        
    }

    

    protected override void OnPause()
    {
      
    }

    protected override void OnResume()
    {
        
    }

    protected override void OnUpdate()
    {
        //mov

        //HealthBarcontroller.updateHealthbar();


    }

       

   
    void Update()
    {
        
    }


    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        ManagerUI.UpdateLife(life.Live,life.lifeMax);

    }

    public override void Health(int healQuantity)
    {
        base.Health(healQuantity);

        ManagerUI.UpdateLife(life.Live, life.lifeMax);

        print("se curo");
    }

    public void ContactAttack(int dmg)
    {
        TakeDamage(dmg);
        Debug.Log("ataque especial");
    }

    public void BulletDmg(int dmg)
    {
        TakeDamage(dmg);
        Debug.Log("ataque bala");
    }
}
