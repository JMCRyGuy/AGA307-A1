using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Projectile"))
        {
            Renderer ren = GetComponent<Renderer>();
            if (ren != null)
            {
                ren.material.color = Color.cyan;
            }
            Destroy(gameObject, 1f);
        }
    }

}
