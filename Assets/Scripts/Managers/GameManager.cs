using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
            //DontDestroyOnLoad(this.gameObject); para usarse en escenas posteriores si se requiere
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    Player player;

    public void SetPlayer(Player _player)
    {
        player = _player;
    }

    public Player GetPlayer()    //para que el enemigo lo use 
    {
        return player;
    }

    public Transform GetPlayerTransform()
    {
        return player.transform;
    }
    


}
