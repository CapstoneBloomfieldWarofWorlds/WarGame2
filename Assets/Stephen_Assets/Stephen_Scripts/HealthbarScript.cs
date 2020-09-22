using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarScript : MonoBehaviour
{
    public Slider healthslider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMaxHealth(int playerHealth)
    {
        healthslider.maxValue = playerHealth;
        healthslider.value = playerHealth;
    }

    public void SetPlayerHealth(int playerHealth)
    {
        healthslider.value = playerHealth;


    }
}
