using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Script : MonoBehaviour
{
    public float rayLenght = 1f;
    public float damage;
    private RaycastHit objectHit;


    public GameObject bullet;



    public LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void  FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.forward * rayLenght, Color.blue);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        if (Physics.Raycast(transform.position, transform.forward, out objectHit, rayLenght, layerMask))
        {
            GameObject ImpactGameObject = Instantiate(bullet, objectHit.point, transform.rotation);

            Destroy(ImpactGameObject, 4F);
            print("I hit" + objectHit.collider.gameObject.name);
        }

        Enemy enemyRef = objectHit.transform.GetComponent<Enemy>();
        {
            if(enemyRef != null)
            {
                enemyRef.TakeDamge(damage);
            }
        }

        



    }



    
}
