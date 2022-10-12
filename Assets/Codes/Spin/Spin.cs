using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RotateScript : MonoBehaviour
{
    void Start()
    {
    
    }

    void Update()
    {
        transform.Rotate(0f, 1000000f, 0f, Space.Self);
    }
}

