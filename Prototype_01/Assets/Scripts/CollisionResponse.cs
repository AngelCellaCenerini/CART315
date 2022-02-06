using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Transform spawnPoint;

    /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("collided");
            this.GetComponent<Rigidbody>().AddForce(0, 0, 1000);
        }
    }*/

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.position = spawnPoint.position;
            Debug.Log("collided");

        }
    }
}
