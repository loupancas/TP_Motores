using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    
    [SerializeField] LifeEntity life;
    void Start()
    {
        life.DeathEvent += Playermuere;
    }


    void Playermuere()
    {
        
            Debug.Log("muerteeeeeeeeeeeeeeeeeeeee");
        

    }

    private void OnDisable()
    {
        life.DeathEvent -= Playermuere;
    }
}
