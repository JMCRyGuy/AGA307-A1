using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum enemyType
{
    Ranger,
    OneHanded,
    TwoHanded
}




public class EmemyScript : MonoBehaviour
{
    float moveDist = 500;

    public enemyType curEnemyType;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        if (curEnemyType == enemyType.Ranger)
        {

        }
        if (curEnemyType == enemyType.Ranger)
        {

        }
        if (curEnemyType == enemyType.Ranger)
        {

        }
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.O))
        {
            StartCoroutine(Move());
        }
    }

    IEnumerator Move()
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

}
