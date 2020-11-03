using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    private Transform target;
    private bool followPlayer;
    public float minY = -2.6f;
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Follow();   
    }
    void Follow()
    {
        if(target == null)
        {
            followPlayer = false;
        }
        else
        {
            followPlayer = true;
        }
        if (followPlayer)
        {
            Vector3 temp = transform.position;
            temp.y = target.position.y;
            transform.position = temp;
        }
    }
}
