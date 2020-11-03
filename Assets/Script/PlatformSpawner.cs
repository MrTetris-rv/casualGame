using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public static PlatformSpawner instance;
    [SerializeField] 
    private GameObject leftPlatform, rightPlatform;
    private float left_X_Min = -2f, left_X_Max = -0.76f, right_X_Min = 2f, right_X_Max = 0.76f;
    private float y_Treshold = 4.6f; //высота между платформами
    private float last_Y;
    public int spawn_Count = 8;
    private int platform_Spawned;

    [SerializeField]
    private Transform platform_Parent;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        last_Y = transform.position.y;

        SpawnPlatform();
    }
    // Update is called once per frame
    public void SpawnPlatform()
    {
        Vector2 temp = Vector2.zero;
        GameObject newPatform = null;

        for(int i = 0; i < spawn_Count; i++)
        {
            temp.y = last_Y;
            if((platform_Spawned % 2) == 0){
                temp.x = Random.Range(left_X_Min, left_X_Max);
                newPatform = Instantiate(rightPlatform, temp, Quaternion.identity);
            }
            else
            {
                temp.x = Random.Range(right_X_Min, right_X_Max);
                newPatform = Instantiate(leftPlatform, temp, Quaternion.identity);
            }
            newPatform.transform.parent = platform_Parent;

            last_Y += y_Treshold;
            platform_Spawned++;
        }
    }
}
