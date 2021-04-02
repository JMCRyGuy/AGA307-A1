using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* public enum enemyType
{
    Ranger,
    OneHanded,
    TwoHanded
}
*/




public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public Vector3 walkPoint;
    public bool walkPointSet;
    public float walkPointRange;
    public LayerMask whatIsGround;
    public Animator animator;
    // Current Stats
    private float curScale;
    private float curSpeed;
    public float curHealth;
    private float curMaxHealth;
    [Header("Small Stats")]
    public float smaScale = 0.5f;
    public float smaSpeed = 2f;
    public float smaHealth = 3f;
    [Header("Medium Stats")]
    public float medScale = 1f;
    public float medSpeed = 1f;
    public float medHealth = 5f;
    [Header("Large Stats")]
    public float larScale = 5f;
    public float larSpeed = 0.2f;
    public float larHealth = 10f;

    float moveDist = 500;

    // public enemyType curEnemyType;

    // Start is called before the first frame update

    // Update is called once per frame
    
    void Start()
    {
/*
        if (curEnemyType == enemyType.Ranger)
        {

        }
        if (curEnemyType == enemyType.Ranger)
        {

        }
        if (curEnemyType == enemyType.Ranger)
        {

        }
*/
    }

    void Update()
    {
        WalkAround();
/*
        if (Input.GetKeyDown(KeyCode.O))
        {
            StartCoroutine(Move());
        }
*/
    }

    public void SetStats(float scale, float speed, float health)
    {
        curScale = scale;
        curSpeed = speed;
        curHealth = health;
        transform.localScale = transform.localScale * scale;
    }


    void WalkAround()
    {
        if (!walkPointSet)
        {
            float randomX = Random.Range(-walkPointRange, walkPointRange);
            float randomZ = Random.Range(-walkPointRange, walkPointRange);
            walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
            if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            {
                walkPointSet = true;
            }
            


        }
        else
        {
            agent.SetDestination(walkPoint);
            Vector3 distanceToWalkPoint = transform.position - walkPoint;
            if (distanceToWalkPoint.magnitude < 1f)
            {
                walkPointSet = false;
            }    
        }
        animator.SetFloat("Speed", agent.velocity.magnitude);
        print(agent.velocity.magnitude);
    }

    public void TakeDamage(float dmgAmount)
    {
        curHealth = curHealth - dmgAmount;
        animator.SetFloat("Health", curHealth);
        animator.SetFloat("RandomSeed", Random.Range(0, 10));
    }








    /*     IEnumerator Move()
        {
            for(int i = 0; i  < moveDist; i++)
            {
                transform.Translate(Vector3.forward * Time.deltaTime);
                yield return null;
            }
            transform.Rotate(Vector3.up * 180);
            yield return new WaitForSeconds(3f);
            StartCoroutine(Move());
        }
    */
}
