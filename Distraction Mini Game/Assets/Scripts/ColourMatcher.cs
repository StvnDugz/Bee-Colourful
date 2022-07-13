using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourMatcher : MonoBehaviour
{
    private ColourChangerManager colourChange;
    private AudioSource scoreAudio;
    private const float LowPitch = .5f;
    private const float HighPitch = 1.5f;

    void Start()
    {
        colourChange = GetComponent<ColourChangerManager>();
        scoreAudio = GetComponent<AudioSource>();
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag != colourChange.currentColour)
        {
            GameManager.instance.LevelFailed();
        }

        if (col.tag == colourChange.currentColour)
        {
            Debug.Log("+ 1 point");
            ScoreManager.instance.PlayerScored();
            scoreAudio.pitch = Random.Range(LowPitch, HighPitch);
            scoreAudio.Play();
            Destroy(col.gameObject);
        }
    }
}
