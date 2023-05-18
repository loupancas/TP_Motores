using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public CharacterController characterController;
   public float speed = 10f;
   private float gravity = -9.81f;

    public Transform groundCheck;
    public float sphere = 0.3f;
    public LayerMask groundMask;
    bool isGrounded;

    Vector3 velocity;

    public float jumpHeight = 3f;

    Charview view;

    private void Awake()
    {
        view = GetComponent<Charview>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,sphere,groundMask);

        if(isGrounded&&velocity.y<0)
        {
            velocity.y = -2f; //evita que no se pare de bajar
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
      
        if(Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity); // formula para salto
            view.Jump();
        }

        velocity.y += gravity * Time.deltaTime;

        //if(move.magnitude>0.1f)
        //{
            //view.isRunning(true);
        //}
        //else
        //{
            //view.isRunning(false);
        //}

        view.horizontal(Input.GetAxis("Horizontal"));
        view.vertical(Input.GetAxis("Vertical"));

        characterController.Move(move * speed * Time.deltaTime);


        characterController.Move(velocity * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Q))
        {
            view.Grab();
        }




    }
}
