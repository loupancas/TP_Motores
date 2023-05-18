using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Pickeable
{
    public int healQuantity=20;
    protected override void onPick()
    {
        GameManager.gameManager.GetPlayer().Health(healQuantity);
    }
}
