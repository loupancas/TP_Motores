using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<InventoryItem> inventory;
    private Dictionary<ItemData, InventoryItem> itemDictionary; // para chequear si existe o no en el inventario

    private void OnEnable()
    {
        Gem.OnGemCollected += Add;
    }

    private void OnDisable()
    {
        Gem.OnGemCollected -= Add;
    }



    public void Add(ItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData,out InventoryItem item)) // existe?
        {
            item.addToStack();
        }
        else // no existe? crear
        {
            InventoryItem newItem = new InventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
        }
    }

    public void Remove (ItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData,out InventoryItem item))
        {
            item.removeFromStack();
            if(item.stackSize==0)
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
            }
        }
    }





}
