using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamge(float damgeAmount)
    {
        health -= damgeAmount;

        if(health <= 0)
        {
            Die();
        }
    }

     void Die()
    {
        Destroy(gameObject);
    }
}
