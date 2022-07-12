using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    public ColourChangerManager colourChange;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Changed colour");
        colourChange.SetRandomColor();
    }
}
