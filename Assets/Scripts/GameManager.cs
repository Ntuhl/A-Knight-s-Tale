using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : PlayerBehavior
{
    [SerializeField] GameObject ghost;
    [SerializeField] GameObject spider;

    [SerializeField] Transform enemySpawn1;
    [SerializeField] Transform enemySpawn2;
    [SerializeField] Transform enemySpawn3;
    [SerializeField] Transform enemySpawn4;

    [SerializeField] GameObject gameOverText;
    [SerializeField] bool isGameOver = false;

    public static GameManager instance;

    Transform currentSpawn;
    GameObject currentEnemy;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentEnemy = ghost;
        currentSpawn = enemySpawn1;

        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (isGameOver)
        {
            gameOverText.SetActive(true);
        }
    }

    IEnumerator SpawnEnemy()
    {
        while (GetHealth() > 0)
        {
            Instantiate(currentEnemy, currentSpawn.position, Quaternion.identity);
            ChangeEnemy();
            ChangeSpawn();
            yield return new WaitForSeconds(3f);
        }
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
        }
        else if (rand == 2)
        {
            currentSpawn = enemySpawn2;
        }
        else if (rand == 3)
        {
            currentSpawn = enemySpawn3;
        }
        else
        {
            currentSpawn = enemySpawn4;
        }
    }

    public void InitiateGameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
