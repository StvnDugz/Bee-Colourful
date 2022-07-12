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
    private Color colourBlack = Color.black;

    private MeshRenderer meshColour;                 // Reference to the mesh renderer component

    void Start()
    {
        meshColour = GetComponent<MeshRenderer>();
        SetRandomColor();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag != currentColour)
        {
            GameManager.instance.LevelFailed();
        }

        if (col.tag == currentColour)
        {
            Debug.Log("+ 1 point");
            Destroy(col.gameObject);
        }
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
                currentColour = "Black";
                meshColour.material.color = Color.black;
                break;
        }
    }
}
