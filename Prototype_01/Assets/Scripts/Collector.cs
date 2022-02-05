using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // public string collectibleTag;
    public GameObject player;
    public GameObject command;

    void OnTriggerEnter(Collider other)
    {

        //Destroy(gameObject);
        //Debug.Log("In");
        //if(collision.gameObject.tag == collectibleTag)
        //{
        //    GameObject.Destroy(collision.gameObject);
        //}

        if (other.gameObject == player)
        {
            // Pick up by destroying object 
            Destroy(gameObject);
            Debug.Log("In");
            // Make command appear
            command.SetActive(true);
        }
    }
}
