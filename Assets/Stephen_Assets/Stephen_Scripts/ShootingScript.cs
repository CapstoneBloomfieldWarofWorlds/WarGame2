using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public float raylength = 1f;

    private float damage = 5f;

    private RaycastHit objecthit;

    public LayerMask EnemyMask;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * raylength, Color.blue);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
       
    }

    void Shoot()
    {
        if(Physics.Raycast(transform.position, transform.forward, out objecthit, raylength, EnemyMask))
        {
            print("I hit " + objecthit.collider.gameObject.name);

            EnemyScript enemy = objecthit.transform.GetComponent<EnemyScript>();

            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
        else
        {
            print("Missed!");
        }

        
    }
}
