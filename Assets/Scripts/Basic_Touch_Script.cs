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
    void Start()
    {
        
    }
    void OnMouseOver()
    {
        TextMesh.text = splashText;
        textManipulation.mouseOver = true;
        textManipulation.mouseExit = false;
    }
    void OnMouseExit() 
    {
        textManipulation.mouseExit = true;
        textManipulation.mouseOver = false;
    }

}
