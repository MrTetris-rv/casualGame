using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatformsSide : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private bool _isMovingRight = true;

    void Update()
    {
        if (transform.position.x > 2f)
        {
            _isMovingRight = false;
        }
        else if (transform.position.x < -2f)
        {
            _isMovingRight = true;
        }

        transform.position = _isMovingRight ? new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y) : new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
    }
}
