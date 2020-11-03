using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlatform : MonoBehaviour
{
    public float fallSpeed;
    public GameObject platform1;


    void Update()
    {
        Fall();
    }
    void FixedUpdate()
    {
        Dead();
    }
    void Fall()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - fallSpeed * Time.deltaTime);

    }

    
    void Dead()
    {
        if (transform.position.y < -3f)
        {
            Destroy(platform1);
        }
    }

}
