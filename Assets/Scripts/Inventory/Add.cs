using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    Inventory<GameObject> _inventory;

    void Start()
    {
        _inventory = new Inventory<GameObject>();
        _inventory.Add("item", gameObject);
    }



}
