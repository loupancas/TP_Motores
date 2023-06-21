using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyTools;

public class Filtro : MonoBehaviour
{
    [SerializeField] Enemigo_Chaser chaser;
    [SerializeField] Enemigo_Dispara dispara;
    [SerializeField] Enemigo_Teletransporte teletransporte;
    Enemy[] enemies;


    private void Start()
    {
        enemies = new Enemy[3];

        var eC = Instantiate(chaser);
        var eD = Instantiate(dispara);
        var eT = Instantiate(teletransporte);

        enemies[0] = eC;
        enemies[1] = eD;
        enemies[2] = eT;

        

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckClosest();
        }
    }

    public void CheckClosest()
    {
        Enemy mostClose = enemies.GetMostClosest(this.transform.position, Filtrar);

        Debug.Log(mostClose.gameObject.name);
    }

    bool Filtrar(Enemy Enem)
    {
        return true;

        //Enemigo_Chaser chaser = (Enemigo_Chaser)Enem;
        //if (chaser == null) return false;
        //else return true;
    }

}
