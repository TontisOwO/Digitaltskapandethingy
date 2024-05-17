using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Basic_Touch_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public SavedData myData;
    public Inventory inventory;
    public TextMeshProUGUI TextMesh;
    public TextManipulation textManipulation;
    public SceneLoader sceneLoader;

    public string scene = "1";
    public string splashText = "Beep Boop";
    public string touchText = "¨Boop!";
    public string correctItemInInventory = "Right Item";

    public bool requiredItem = false;
    public bool pickUp = false;
    public bool pickDown = false;
    public bool itemCondition = false;
    public bool switchScene = false;

    public bool isHammer;
    public bool isKey2;
    public bool isKey3;

    //Anton's addition
    public bool puzzleEntry = false;
    public bool puzzleExit = false;
    void Start()
    {

    }

    void OnMouseDown()
    {
        


        if (pickUp && itemCondition == true)
        {
            TextMesh.text = correctItemInInventory;
            textManipulation.mouseDown = true;
            textManipulation.mouseOver = false;
            textManipulation.mouseExit = false;
            if (switchScene)
            {
                if (puzzleEntry)
                {
                    sceneLoader.EnterPuzzleScene(scene);
                }
                else if (puzzleExit)
                {
                    sceneLoader.ExitPuzzleScene(scene);
                }
                else
                {
                    sceneLoader.LoadScene(scene);
                }
            }
            if (requiredItem)
            {
                if (isHammer)
                {
                    inventory.hammer = true;
                    Debug.Log("HAMMER TIME");
                }

                if (isKey2)
                {
                    inventory.secondFloorKey = true;
                }

                if (isKey3)
                {
                    inventory.thirdFloorKey = true;
                }

                Destroy(gameObject);
                Debug.Log("destroyed");
            }
            
        }
        if (itemCondition != myData.KeyItem)
        {
            itemCondition = true;
        }
        if (itemCondition && requiredItem || pickUp == true)
        {
            Destroy(gameObject);
            Debug.Log("destroyed2");
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
