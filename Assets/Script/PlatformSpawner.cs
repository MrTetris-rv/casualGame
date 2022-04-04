using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public static PlatformSpawner instance;

    [SerializeField] private GameObject _leftPlatform;
    [SerializeField] private GameObject _rightPlatform;
    [SerializeField] private Transform _platform_Parent;
    [SerializeField] private int _spawn_Count = 8;

    private float _left_X_Min = -2f;
    private float _left_X_Max = -0.76f;
    private float _right_X_Min = 2f;
    private float _right_X_Max = 0.76f;
    private float _y_Treshold = 4.6f; 
    private float _last_Y;
    private int _platform_Spawned;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Start()
    {
        _last_Y = transform.position.y;
        SpawnPlatform();
    }
   
    private void SpawnPlatform()
    {
        Vector2 temp = Vector2.zero;
        GameObject newPatform = null;

        for (int i = 0; i < _spawn_Count; i++)
        {
            temp.y = _last_Y;
            if (_platform_Spawned % 2 == 0){
                temp.x = Random.Range(_left_X_Min, _left_X_Max);
                newPatform = Instantiate(_rightPlatform, temp, Quaternion.identity);
            }
            else
            {
                temp.x = Random.Range(_right_X_Min, _right_X_Max);
                newPatform = Instantiate(_leftPlatform, temp, Quaternion.identity);
            }
            newPatform.transform.parent = _platform_Parent;

            _last_Y += _y_Treshold;
            _platform_Spawned++;
        }
    }
}
