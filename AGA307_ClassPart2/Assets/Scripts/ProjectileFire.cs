using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    public float veloc = 5f;
    public Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody.AddForce(rbody.transform.forward * veloc, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
