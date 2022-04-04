using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlatform : MonoBehaviour
{
    [SerializeField] private float _fallSpeed;
    [SerializeField] private GameObject _platform;

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
        transform.position = new Vector2(transform.position.x, transform.position.y - _fallSpeed * Time.deltaTime);
    }
    
    void Dead()
    {
        if (transform.position.y < -3f)
        {
            Destroy(_platform);
        }
    }
}
