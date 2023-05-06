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


    public void Start()
    {
        Invoke(" StartGame",0.1f);
    }

    public void StartGame()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            objects[i].Initialize();
        }
    }




    bool pause = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause; // deja de ser pausa
            Pause(pause);
        }
    }
    public void Pause(bool pause)
    {
        if(pause)
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Pause();
            }
        }
        else
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Resume();
            }
        }
    }





    List<PlayObject> objects = new List<PlayObject>();
    public void AddPlayObject(PlayObject element)
    {
        if (!objects.Contains(element))
        {
            objects.Add(element);
        }
        
    }
    public void RemovePlayObject(PlayObject element)
    {
        if (objects.Contains(element)) 
        {
            objects.Remove(element);
        }

    }



}
