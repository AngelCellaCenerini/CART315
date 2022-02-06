using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject interactionType;
    public GameObject interactive;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if (interactive.activeSelf)
            {
                // Make dialogue appear
                interactionType.SetActive(true);
            }
        }
    }

    public void Talk()
    {
        // Check if Interaction has been "unlocked"
        if(interactive.activeSelf)
        {
            Debug.Log("active");
            // Make dialogue appear
            interactionType.SetActive(true);
        }
    }
}
