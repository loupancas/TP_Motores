using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    Inventory<Pickeable> _inventory;

    void Start()
    {
        _inventory = new Inventory<Pickeable>();
        
    }



    private void OnTriggerEnter(Collider other)
    {
       if(other.GetComponent<Pickeable>())
        {
            _inventory.Add("MediPack", other.GetComponent< Pickeable > ());

            
        }
    }


}
