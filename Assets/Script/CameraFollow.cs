using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{    
   // [SerializeField] private float _minY = -2.6f;
    [SerializeField] private Transform _player;

    private bool _isFollowPlayer;

    void Update()
    {
        Follow();   
    }
    
    private void Follow()
    {
        if(_player == null)
        {
            _isFollowPlayer = false;
        }
        else
        {
            _isFollowPlayer = true;
        }
        
        if (_isFollowPlayer)
        {
            Vector3 temp = transform.position;
            temp.y = _player.position.y;
            transform.position = temp;
        }
    }
}
