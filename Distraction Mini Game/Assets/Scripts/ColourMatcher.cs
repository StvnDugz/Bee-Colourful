using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourMatcher : MonoBehaviour
{
    private ColourChangerManager colourChange;

    void Start()
    {
        colourChange = GetComponent<ColourChangerManager>();
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.tag != colourChange.currentColour)
        {
            GameManager.instance.LevelFailed();
        }

        if (col.tag == colourChange.currentColour)
        {
            Debug.Log("+ 1 point in colourmatcher");
            ScoreManager.instance.PlayerScored();
            Destroy(col.gameObject);
            //pointEarnedAudio.pitch = Random.Range(LowPitch, HighPitch);
            //pointEarnedAudio.Play();

        }
    }
}
