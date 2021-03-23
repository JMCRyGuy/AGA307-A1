using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Sizes
{
    Small,
    Medium,
    Large,
    // ~~~~~~~
    Count
}






public class EnemyManger : Singleton<EnemyManger>
{
    public Transform[] spawnPoints;
    public GameObject[] enemyTypes;
    public List<GameObject> enemies;
    public float spawnDelay = 3f;
    public float numberToSpawn = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            print(i);
            
        }
        //SpawnMultipleEnemies();
        //AdditionOneToTen();
        StartCoroutine(SpawnSequence());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            SpawnEnemy(Random.Range(0, spawnPoints.Length - 1));
        }

    }


    IEnumerator SpawnSequence()
    {
        for(int i = 0; i < numberToSpawn; i++)
        {
            SpawnEnemy(Random.Range(0, spawnPoints.Length - 1));
            yield return new WaitForSeconds(spawnDelay);
        }
        
    }


    void SpawnMultipleEnemies()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            SpawnEnemy(i);
        }
        //print("EC: " + enemies.Count);
    }

    void SpawnEnemy(int x)
    {
        int y = x % spawnPoints.Length;
        GameObject temp = Instantiate<GameObject>(enemyTypes[Random.Range(0, enemyTypes.Length - 1)], spawnPoints[y].position, spawnPoints[y].rotation);

        EnemyScript scriptRef = temp.GetComponent<EnemyScript>();
        Sizes ranSize = (Sizes)Random.Range(0,3);
        switch(ranSize)
        {
            case Sizes.Small:
                scriptRef.SetSizeAndSpeed(scriptRef.smaScale, scriptRef.smaSpeed);
                break;
            case Sizes.Medium:
                scriptRef.SetSizeAndSpeed(scriptRef.medScale, scriptRef.medSpeed);
                break;
            case Sizes.Large:
                scriptRef.SetSizeAndSpeed(scriptRef.larScale, scriptRef.larSpeed);
                break;
            case Sizes.Count:
                print("You Stink!");
                break;


        }
        enemies.Add(temp);
    }

    void AdditionOneToTen()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int y = 1; y <= 10; y++)
            {
                print(i + y);
            }
        }
    }
}
