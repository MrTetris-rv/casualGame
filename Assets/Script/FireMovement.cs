using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{
    GameObject fire;
    public float speed;
   public  GameObject player;
    private bool moveFire;
    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (player == null)
        {
            moveFire = false;
            
        }
        else
        {
            moveFire = true;
          
        }
        if (moveFire)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
    }
}
