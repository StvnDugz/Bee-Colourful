using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangerManager : MonoBehaviour
{
    public string currentColour;
    private Color colourRed = Color.red;
    private Color colourGreen = Color.green;
    private Color colourBlue = Color.blue;
    private Color colourCyan = Color.cyan;
    private Color colourMagenta = Color.magenta;
    private Color colourYellow = Color.yellow;
    private Color colourWhite = Color.white;
    private SkinnedMeshRenderer meshColour;

    void Start()
    {
        meshColour = GetComponent<SkinnedMeshRenderer>();
        SetRandomColor();
    }

    public void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColour = "Cyan";
                meshColour.material.color = Color.cyan;
                break;
            case 1:
                currentColour = "Magenta";
                meshColour.material.color = Color.magenta;
                break;
            case 2:
                currentColour = "Yellow";
                meshColour.material.color = Color.yellow;
                break;
            case 3:
                currentColour = "White";
                meshColour.material.color = Color.white;
                break;
        }
    }
}
