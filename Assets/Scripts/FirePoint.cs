using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    [SerializeField] float offset;
    [SerializeField] Transform shotpoint;

    [SerializeField] GameObject dagger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Input.mousePosition - transform.position;
        float zRotation = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, zRotation + offset);


        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(dagger, shotpoint.position, transform.rotation);
        }
    }
}
