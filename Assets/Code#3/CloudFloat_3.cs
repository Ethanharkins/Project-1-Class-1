using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudFloat_3 : MonoBehaviour
{
    public float speed = 0.1F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - (speed * Time.deltaTime), this.transform.position.z);
    }
}
