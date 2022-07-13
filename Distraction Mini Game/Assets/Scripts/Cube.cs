using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 20f;
    private AudioSource hitAudio;       // Reference to the audio source component
    void Start()
    {
        GetComponent<Rigidbody>().drag -= Time.timeSinceLevelLoad / speed;
        hitAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        // If this object collides with the object tagged
        if (other.gameObject.CompareTag("Player"))
        {
            hitAudio.Play();
        }
    }
}
