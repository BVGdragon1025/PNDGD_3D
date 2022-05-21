using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Private Variables
    private ParticleSystem ps;

    void Awake()
    {
        ps = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ps.Play();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            ps.Stop();
        }
    }
}
