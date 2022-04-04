using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{
    //GameObject fire;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _player;

    private bool _isMoveFire;

    void Update()
    {
        Movement();
    }
    
    private void Movement()
    {
        _isMoveFire = _player != null;
        if (_isMoveFire)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + _speed * Time.deltaTime);
        }
    }
}
