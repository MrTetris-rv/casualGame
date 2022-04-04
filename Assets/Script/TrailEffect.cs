using System;
using UnityEngine;

public class TrailEffect : MonoBehaviour
{
    [SerializeField] private float _timeBtwSpawns;
    [SerializeField] private float _startTimeBtwSpawns;
    [SerializeField] private GameObject _player;

    private void Start()
    {
        Debug.Log("hello");
    }

    private void Update()
    {
        /*{
            if(_timeBtwSpawns <= 0)
            {
                Instantiate(_player, transform.position, Quaternion.identity);
                _timeBtwSpawns = _startTimeBtwSpawns;
            }
            else
            {
                _timeBtwSpawns -= Time.deltaTime;
            }
        }*/
    }
}
