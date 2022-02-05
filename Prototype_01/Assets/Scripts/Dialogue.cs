using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject interactionType;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.E))
        {
            // Make dialogue appear
            interactionType.SetActive(true);
        }
    }

    public void Talk()
    {
        // Make dialogue appear
        interactionType.SetActive(true);
    }
}
