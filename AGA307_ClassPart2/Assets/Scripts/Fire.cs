using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Fire : MonoBehaviour
{
    public ProjectileFire projectileA;
    public Transform firePoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
           ProjectileFire newProjectile = Instantiate<ProjectileFire>(projectileA, firePoint.position, firePoint.rotation);
        }
    }
}
