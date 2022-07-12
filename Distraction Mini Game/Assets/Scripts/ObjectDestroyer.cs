using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Destroyed object");
        Destroy(other.gameObject);
    }
}
