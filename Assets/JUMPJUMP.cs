using Core.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR.Interaction.Toolkit;

public class JUMPJUMP : MonoBehaviour
{
    public InputActionReference test;
    public InputActionAsset bloop;
    

    

    // Start is called before the first frame update
    void Start()
    {
        if (bloop != null) 
        { 
            bloop.Enable();
        };

    }

    // Update is called once per frame
    void Update()
    {
        if(test.action.ReadValue<float>()  == 1)
        {
            Debug.Log("test");
        }



    }
}
