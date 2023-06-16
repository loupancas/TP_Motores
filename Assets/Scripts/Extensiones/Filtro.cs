using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyTools;

public class Filtro : MonoBehaviour
{
    Enemigo_Chaser chaser;
    Enemigo_Dispara dispara;
    Enemigo_Teletransporte teletransporte;

    private void Start()
    {
        Enemy[] enemies =
        {
            Instantiate(chaser),
            Instantiate(dispara),
            Instantiate(teletransporte),
        };
        Enemy mostClose = enemies.GetMostClosest(this.transform.position,Filtrar);
    }

    bool Filtrar(Enemy Enem)
    {
        Enemigo_Chaser chaser = (Enemigo_Chaser)Enem;
        if (chaser == null) return false;
        else return true;
    }

}
