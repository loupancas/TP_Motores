using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour, ICollectible
{
    
    public ItemData gemData;
   

    public void Collect()
    {
       
        Inventario.instance.Add(gemData);
        Destroy(gameObject);

    }



}
