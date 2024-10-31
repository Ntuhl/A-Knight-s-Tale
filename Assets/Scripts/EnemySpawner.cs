using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject ghost;
    [SerializeField] GameObject spider;

    [SerializeField] Transform enemySpawn1;
    [SerializeField] Transform enemySpawn2;
    [SerializeField] Transform enemySpawn3;
    [SerializeField] Transform enemySpawn4;

    Transform currentSpawn;
    GameObject currentEnemy;

    // Start is called before the first frame update
    void Start()
    {
        currentEnemy = ghost;
        currentSpawn = enemySpawn1;

    }

    private void SpawnEnemy()
    {

        Instantiate(currentEnemy, currentSpawn.position, Quaternion.identity);
        ChangeEnemy();
        ChangeSpawn();
    }

    private void ChangeEnemy()
    {
        if (currentEnemy == ghost)
        {
            currentEnemy = spider;
        }
        else
        {
            currentEnemy = ghost;
        }
    }

    private void ChangeSpawn()
    {
        int rand = Random.Range(1, 5);
        if (rand == 1)
        {
            currentSpawn = enemySpawn1;
        }else if(rand == 2)
        {
            currentSpawn = enemySpawn2;
        }else if (rand == 3)
        {
            currentSpawn = enemySpawn3;
        }else
        {
            currentSpawn = enemySpawn4;
        }
    }
}
