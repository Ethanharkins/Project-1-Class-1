using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.red;
    }
}
