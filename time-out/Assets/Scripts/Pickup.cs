using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //player picks up the key
        if (collision.collider.tag == "Player")
        {
            //PlayerController.instance.SetKey(true);
           // Debug.Log("You got the key");

            //steal time?
            collision.gameObject.GetComponent<Timer>().currentTime += 10.0f;


            Destroy(gameObject);
        }
    }
}
