using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    //Public Variables
    public string SpawnPoolTag = "EnemyPool";
    public float SpawnInterval = 5f;

    //Private Variables
    private ObjectPool pool = null;

    void Awake()
    {
        pool = GameObject.FindWithTag(SpawnPoolTag).GetComponent<ObjectPool>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", SpawnInterval, SpawnInterval);
    }

    public void Spawn()
    {
        pool.Spawn(null, transform.position, transform.rotation, Vector3.one);
    }

}
