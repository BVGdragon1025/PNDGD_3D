using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    //Public Variables
    public UnityEvent onHealthChanged;
    public string spawnPoolTag = string.Empty;
    public float HealthPoints { 
        get { return HealthPoints; }
        set { HealthPoints = value; 
        onHealthChanged?.Invoke();
        if(HealthPoints <= 0f)
            {
                Die();
            }
        
        }
    }

    //Private Variables
    [SerializeField] private float healthPoints = 100f;
    private ObjectPool pool = null;

    void Awake()
    {
        if(spawnPoolTag.Length > 0)
        {
            pool = GameObject.FindWithTag(spawnPoolTag).GetComponent<ObjectPool>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HealthPoints = 0;
        }
    }

    private void Die()
    {
        if(pool != null)
        {
            pool.DeSpawn(transform);
            healthPoints = 100f;
        }
    }

}
