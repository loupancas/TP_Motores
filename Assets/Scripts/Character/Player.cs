using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities.LifeSystem;


public class Player : LifeEntity
{
    Life life;

    protected override void Awake()
    {
       // base.Awake();//life = new Life(100);
    }
    protected override void OnInitialize()
    {
        GameManager.instance.SetPlayer(this); // se asigna a sí mismo
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
    }

       
    
    void Start()
    {
       
    }

   
    void Update()
    {
        
    }


}
