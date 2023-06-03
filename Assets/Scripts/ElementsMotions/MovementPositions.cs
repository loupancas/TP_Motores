using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPositions : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float ObjectSpeed;

    int NextPosIndex;
    Transform NextPos;

    void Start()
    {
        NextPos = Positions[0];
    }

    
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if(transform.position==NextPos.position)
        {
            NextPosIndex++;
            if (NextPosIndex>=Positions.Length)
            {
                NextPosIndex = 0;
            }
        }
    }


}
