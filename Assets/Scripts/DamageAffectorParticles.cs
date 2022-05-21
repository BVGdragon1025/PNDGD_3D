using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAffectorParticles : MonoBehaviour
{
    //Public Varibles
    public string tagDamage = "Enemy";
    public float damageAmount = 2f;

    //Private Variables
    private Health thisHealth = null;

    // Start is called before the first frame update
    void Awake()
    {
        thisHealth = GetComponent<Health>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag(tagDamage))
        {
            thisHealth.HealthPoints -= damageAmount;
        }
    }

}
