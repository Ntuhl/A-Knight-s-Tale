using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : EnemyBehavior
{
    [SerializeField] float offset;
    [SerializeField] Transform shotpoint;
    [SerializeField] Transform shotpoint2;
    [SerializeField] Transform shotpoint3;

    [SerializeField] GameObject dagger;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float zRotation = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, zRotation + offset);


        if (Input.GetButtonDown("Fire1"))
        {
            if (GetKillCount() > 30)
            {
                Instantiate(dagger, shotpoint.position, transform.rotation);
                Instantiate(dagger, shotpoint2.position, transform.rotation);
                Instantiate(dagger, shotpoint3.position, transform.rotation);
            }
            else if (GetKillCount() > 20)
            { 
                Instantiate(dagger, shotpoint.position, transform.rotation);
                Instantiate(dagger, shotpoint2.position, transform.rotation);
            }
            else
            {
                Instantiate(dagger, shotpoint.position, transform.rotation);
               
            }

        }
    }
}
