using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    
    
    [SerializeField] float speed;

    private Transform target;


    private float killCount;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.InitiateGameOver();
        }
        Destroy(gameObject);
        Destroy(collision.gameObject);
        killCount ++;
    }

    public float GetKillCount()
    {
        return killCount;
    }
}
