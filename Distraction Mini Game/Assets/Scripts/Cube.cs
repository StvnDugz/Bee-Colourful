using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        // If this object collides with the object tagged
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You died");
            Destroy(gameObject);
        }
    }
}
