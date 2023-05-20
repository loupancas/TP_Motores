using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimEvents : MonoBehaviour
{
    public Charview view;
    public Movement Movement;

    public void ANIMEV_Launch()
    {
        Movement.AnimEV_RealJump();
    }



}
