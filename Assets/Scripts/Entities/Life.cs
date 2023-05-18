using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entities.LifeSystem
{

public class Life 
{
    private int currentlife;
    public int lifeMax;

    public int Live
    {
        get
        {
            return currentlife;
                
        }
        set
        {
            if(value<0)
            {
                currentlife = 0;
            }
            else if (value > lifeMax)
            {
                currentlife = lifeMax;
            }
            else
            {
                currentlife = value;
            }
        }

            

    }




    public Life(int _maxlife) //constructor
    {
        currentlife = _maxlife;
        lifeMax= _maxlife;


    }

    public Life(int _maxlife,int _currentLife) //****constructor se puede usar porque tiene una sobrecarga _currentlife
    {
        currentlife = _currentLife;
        lifeMax = _maxlife;

    }

  





}

}
