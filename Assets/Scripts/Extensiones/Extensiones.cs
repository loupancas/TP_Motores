using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MyTools
{
    public static class Extensiones 
    {
        public static T GetMostClosest<T>(this T[] col, Vector3 posPlayer, Func<T, bool> predicate) where T : Component
        {
            float mostClose = int.MaxValue;
            T mcVal = null;
            for (int i = 0; i < col.Length; i++)
            {
                if (predicate.Invoke(col[i]))
                {
                    float dist = Vector3.Distance(posPlayer, col[i].transform.position);
                    if (dist < mostClose)
                    {
                        mostClose = dist;
                        mcVal = col[i];
                    }

                }

            }

            return mcVal;
        }


    }
}

