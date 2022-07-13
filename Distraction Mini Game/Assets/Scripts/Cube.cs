using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 20f;
    void Start()
    {
        GetComponent<Rigidbody>().drag -= Time.timeSinceLevelLoad / speed;
    }
}
