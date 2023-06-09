using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory<T>
{
    public Dictionary<string, T> items = new Dictionary<string, T>();

    public void Add(string name, T obj)
    {

    }

    public T Get(string name)
    {
        return default;
    }


}
