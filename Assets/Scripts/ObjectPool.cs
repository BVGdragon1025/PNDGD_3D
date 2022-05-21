using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    //Public variables
    public GameObject objectPrefab = null;
    public int poolSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePool();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GeneratePool()
    {
        for(int i=0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab, Vector3.up, Quaternion.identity, transform);
            obj.SetActive(false);
        }
    }

    public Transform Spawn(Transform parent, Vector3 position = new Vector3(), Quaternion rotation = new Quaternion(), Vector3 scale = new Vector3())
    {
        if(transform.childCount <= 0)
        {
            return null;
        }
        Transform child = transform.GetChild(0);
        child.SetParent(parent);
        child.rotation = rotation;
        child.localScale = scale;
        child.gameObject.SetActive(true);
        return child;
    }

    public void DeSpawn(Transform objectToDespawn)
    {
        objectToDespawn.gameObject.SetActive(false);
        objectToDespawn.SetParent(transform);
        objectToDespawn.position = Vector3.zero;
    }

}
