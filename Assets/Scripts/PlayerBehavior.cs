using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    [SerializeField] float movementSpeed;
    [SerializeField] int attackDamage;
    [SerializeField] float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveInputRight = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveInputRight * movementSpeed * Time.deltaTime);
        float moveInputUp = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * moveInputUp * movementSpeed * Time.deltaTime);
    }

    public float GetHealth()
    {
        return health;
    }
    
}
