using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatformsSide : MonoBehaviour
{
    public float Speed = 2f;
    float hor;
    bool MovingRight = true;

 
  
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 2f)
        {
            MovingRight = false;
        }else if(transform.position.x < -2f)
        {
            MovingRight = true;
        }
        if (MovingRight)
        {
            transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
        }
    }
}
