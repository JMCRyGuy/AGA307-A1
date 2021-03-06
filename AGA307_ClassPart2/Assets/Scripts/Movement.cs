using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxisRaw("Horizontal");
        float movez = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right* movex +transform.forward * movez;

        rb.MovePosition(transform.position + move.normalized * speed * Time.deltaTime);
    }
}
