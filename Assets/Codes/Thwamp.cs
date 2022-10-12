using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thwamp : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter2D(Collider2D collision)
   {
        //Destroy Other Object
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
       
   }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
 