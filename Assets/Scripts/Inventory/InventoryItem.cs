using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class InventoryItem 
{
    public ItemData itemData;

    public int stackSize;


    public InventoryItem(ItemData item)  // constructor
    {
        itemData = item;
        addToStack();
    }

    public void addToStack()
    {
        stackSize++;
    }

    public void removeFromStack()
    {
        stackSize--;
    }



}
