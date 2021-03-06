using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas hudRef;

    void Start()
    {
        
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("Player"))
        {
           
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.collider.CompareTag("Player"))
        {
            
        }
    }


}
