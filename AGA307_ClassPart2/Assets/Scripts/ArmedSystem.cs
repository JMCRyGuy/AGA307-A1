using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmedSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;
    private Color colourRef;
    
    void Start()
    {
        colourRef = target.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    
    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            if (target != null)
            {
                target.GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            if (target != null)
            {
                target.GetComponent<Renderer>().material.color = colourRef;
            }
        }
    }
}
