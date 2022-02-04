using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{
    public GameObject player;
    /* public string collectibleTag;
    public string collectibleTag2;
    GameObject gameObjectToMove;
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
             //if (collision.gameObject.tag == collectibleTag)
            //{
                Debug.Log("collided");
                // this.GetComponent<Rigidbody>().AddForce(0, 0, 1000);
                this.GetComponent<Rigidbody>().AddForce(0, 0, 1000);
            //}

            /* if (collision.gameObject.tag == collectibleTag2)
            {
                Debug.Log("collided"); 
                gameObjectToMove.transform.position = new Vector3(8, 0, 2);
            }
            */
        }
    }

}
