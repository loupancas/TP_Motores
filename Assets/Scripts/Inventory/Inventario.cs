using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<InventoryItem> inventory;
    private Dictionary<ItemData, InventoryItem> itemDictionary=new Dictionary<ItemData, InventoryItem>(); // para chequear si existe o no en el inventario

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
        if(itemDictionary.TryGetValue(itemData,out InventoryItem item)) // existe? añadir
        {
            item.addToStack();
            Debug.Log($"{ item.itemData.displayName} La cantidad total ahora es {item.stackSize}");
        }
        else // no existe? crear
        {
            InventoryItem newItem = new InventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            Debug.Log($"Se añadió { itemData.displayName} por primera vez");
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
