using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsChecker : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        // Check if the object exiting is the Cube
        if (other.gameObject.CompareTag("Cube"))
        {
            // Increment the player's score
            ScoreManager.Instance.IncrementPlayerScore();
        }
    }
}

