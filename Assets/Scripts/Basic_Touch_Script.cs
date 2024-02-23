using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Basic_Touch_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI TextMesh;
    public TextManipulation textManipulation;
    public string splashText = "Beep Boop";
    public string touchText = "�Boop!";
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        TextMesh.text = touchText;
        textManipulation.mouseDown = true;
        textManipulation.mouseOver = false;
        textManipulation.mouseExit = false;
    }

    void OnMouseOver()
    {
        if (textManipulation.mouseDown == false) 
        { 
            TextMesh.text = splashText; 
            textManipulation.mouseOver = true;
        }
        textManipulation.mouseExit = false;
    }
    void OnMouseExit() 
    {
        textManipulation.mouseDown = false;
        textManipulation.mouseExit = true;
        textManipulation.mouseOver = false;
    }

}
