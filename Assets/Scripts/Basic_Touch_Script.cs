using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Basic_Touch_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public SavedData myData = null;
    public TextMeshProUGUI TextMesh;
    public TextManipulation textManipulation;
    
    public string splashText = "Beep Boop";
    public string touchText = "¨Boop!";
    public string correctItemInInventory = "Right Item";

    public bool requiredItem = false;
    public bool pickUp = false;
    public bool itemCondition = false;
    void Start()
    {

    }

    void OnMouseDown()
    {
        
        if (pickUp && itemCondition == true)
        {
            myData.KeyItem = true;
            Destroy(gameObject);
            TextMesh.text = correctItemInInventory;
            textManipulation.mouseDown = true;
            textManipulation.mouseOver = false;
            textManipulation.mouseExit = false;
        }
        if (itemCondition != myData.KeyItem)
        {
            itemCondition = true;
        }
        if (itemCondition && requiredItem || pickUp == true)
        {
            Destroy(gameObject);
            TextMesh.text = correctItemInInventory;
            textManipulation.mouseDown = true;
            textManipulation.mouseOver = false;
            textManipulation.mouseExit = false;
        }
        else
        {
            TextMesh.text = touchText;
            textManipulation.mouseDown = true;
            textManipulation.mouseOver = false;
            textManipulation.mouseExit = false;
        }
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
