using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float gravity = -4;
    
    public CharacterController controller;
    //Vector3 veloc;
    
    void Start()
    {

    }

    
    void Update()
    {
        float movex = Input.GetAxisRaw("Horizontal");
        float movez = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * movex + transform.forward * movez;

        controller.Move(move * speed * Time.deltaTime);


    }

/*
    veloc.y += gravity* Time.deltaTime;
    controller.Move(veloc* Time.deltaTime);
*/
        
}
