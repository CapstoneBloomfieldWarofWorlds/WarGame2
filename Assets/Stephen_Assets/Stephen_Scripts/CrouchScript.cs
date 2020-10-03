using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    CharacterController controller;
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            controller.height = 1.0f;

        }

        else
        {
            controller.height = 1.8f;
        }
    }
}
