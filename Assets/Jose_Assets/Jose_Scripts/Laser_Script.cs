using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Script : MonoBehaviour
{
    public float rayLenght = 1f;
    public float damage;
    private RaycastHit objectHit;
    public Transform endBarrel;


   



    public LayerMask layerMask;

    public GameObject laserImpactEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void  Update()
    {
        Debug.DrawRay(endBarrel.position, endBarrel.forward * rayLenght, Color.blue);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

           

        }

       
    }


    void Shoot()
    {
        if (Physics.Raycast(endBarrel.position, transform.forward, out objectHit, rayLenght, layerMask))
        {



            print("I hit" + objectHit.collider.gameObject.name);


            
        }

        else
        {
            print("Miss!");
        }

        Enemy enemyRef = objectHit.transform.GetComponent<Enemy>();
        {
            if(enemyRef != null)
            {
                enemyRef.TakeDamge(damage);
            }
        }

        GameObject impactGameObject = Instantiate(laserImpactEffect, objectHit.point, transform.rotation);

        Destroy(impactGameObject, 1f);

        

        



    }



    
}
