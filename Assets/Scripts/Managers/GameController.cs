using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    LifeEntity life;
    void Start()
    {
        //life.Dead += Playermuere;
    }


    void Playermuere()
    {
        
            Debug.Log("muerteeeeeeeeeeeeeeeeeeeee");
        

    }

    private void OnDisable()
    {
        //life.Dead -= Playermuere;
    }
}
