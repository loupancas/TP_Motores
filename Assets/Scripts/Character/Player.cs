using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    void Start()
    {
        GameManager.instance.SetPlayer(this); // se asigna a sí mismo
    }

   
    void Update()
    {
        
    }
}
