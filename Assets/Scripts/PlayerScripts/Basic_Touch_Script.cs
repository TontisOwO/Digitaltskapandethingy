using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Basic_Touch_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioManager audioManager;
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
    public bool isBuildingKey;

    //Anton's addition
    public bool puzzleEntry = false;
    public bool puzzleExit = false;
    void Start()
    {
        Debug.Log("Start");
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void OnMouseDown()
    {

        Debug.Log("Fun");

        if (pickUp && itemCondition)
        {
            TextMesh.text = correctItemInInventory;
            textManipulation.mouseDown = true;
            textManipulation.mouseOver = false;
            textManipulation.mouseExit = false;
            if (switchScene)
            {
                Debug.Log("Switch");
                if (puzzleEntry)
                {
                    sceneLoader.EnterPuzzleScene(scene);
                    audioManager.PlaySFX(audioManager.door);
                }
                else if (puzzleExit)
                {
                    Debug.Log("Bruh");
                    sceneLoader.ExitPuzzleScene(scene);
                    audioManager.PlaySFX(audioManager.door);
                }
                else
                {
                    sceneLoader.LoadScene(scene);
                    audioManager.PlaySFX(audioManager.door);
                }
            }
            if (requiredItem)
            {
                if (isHammer)
                {
                    inventory.hammer = true;
                    myData.CrubrItem = true;
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

                if (isBuildingKey)
                {
                    myData.BuildingKey = true;
                }

                Destroy(gameObject);
                Debug.Log("destroyed");
            }
            
        }

        if ((itemCondition && requiredItem || pickUp == true) && !switchScene)
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
