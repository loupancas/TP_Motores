using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerSensor : MonoBehaviour
{
    [SerializeField] UnityEvent EV_OnPlayerEnter;
    [SerializeField] UnityEvent EV_OnPlayerExit;

    private void OnTriggerEnter(Collider other)
    {
       
            if (IsPlayer(other))
            {
              EV_OnPlayerEnter.Invoke();
                print("enter");
            }

        
    }
    private void OnTriggerExit(Collider other)
    {
       
            if (IsPlayer(other))
            {
                EV_OnPlayerExit.Invoke();
                print("exit");
            }

       
            
    }
    private void OnTriggerStay(Collider other)
    {
        
            if (IsPlayer(other))
            {
                print("stay");
            }

       
            
    }

    bool IsPlayer(Collider col)
    {
        Player c = col.GetComponent<Player>();
        if (c == GameManager.gameManager.GetPlayer())
        {
            return true;

        }      
        return false;
    }


}
