using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    Rigidbody rgb;
    [SerializeField] float throwForce = 5f;
    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();

    }

    public void throwBomb(Vector3 pos,Vector3 dir)
    {
        this.transform.position = pos;
        rgb.AddForce(dir *throwForce,ForceMode.VelocityChange);
        Destroy(this.gameObject, 2f);
    }



}
