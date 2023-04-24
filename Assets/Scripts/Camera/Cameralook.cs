using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameralook : MonoBehaviour
{
    public float mouseSensitivity = 80f;
    public Transform Character;
    float xRotation = 0;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // locked en  la ventana
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-45f,45f); // para que la camara mire de arriba abajo
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        Character.Rotate(Vector3.up*mouseX);
    }
}
