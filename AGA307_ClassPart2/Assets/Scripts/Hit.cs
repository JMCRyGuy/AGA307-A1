using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    EnemyScript scriptRef;
    float preSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        scriptRef = gameObject.GetComponent<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Projectile"))
        {
            Destroy(col.gameObject);
            Renderer ren = GetComponent<Renderer>();
            if (ren != null)
            {
                ren.material.color = Color.cyan;
                
                Destroy(gameObject, 1f);
            }

            if (scriptRef != null)
            {
                preSpeed = scriptRef.agent.speed;
                scriptRef.agent.speed = 0f;
                scriptRef.TakeDamage(1f);
                scriptRef.animator.SetTrigger("Hit");
                if (scriptRef.curHealth <= 0)
                {
                    for (int i = 0; i < EnemyManger.instance.enemies.Count; i++)
                    {
                        if (EnemyManger.instance.enemies[i] == gameObject)
                        {

                            GameManager.instance.AddScore(1);
                            EnemyManger.instance.enemies.Remove(gameObject);
                            Destroy(gameObject, 5f);
                            break;
                        }
                    }
                }
                else
                {
                    Invoke("RevertSpeed", 1f);

                }




            }
            
        }
    }
    void RevertSpeed()
    {
        scriptRef.agent.speed = preSpeed;
    }


}
