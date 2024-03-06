using JetBrains.Annotations;
using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

// By the way I changed some code like the key not being in the inventory at start.
// ask me if you encounter problems - Azure

public class InventoryScript : MonoBehaviour
{
    public SavedData myData = null;




    void Start()
    {

    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (transform.localPosition.x >= -100.0f)
            {
                Slide(20);
                Debug.Log(transform.gameObject.name);
                Debug.Log(transform.localPosition);
            }
            else
            {
                Debug.Log(transform.gameObject.name);
                Debug.Log(transform.localPosition);

            }
        }
        
    }

    void DropItems()
    {
        
    }
    //Code for the backpack to slide into view.
    void Slide(float slideAmount)
    {
        bool backpackState = false;
        Vector3 backpackPos = new Vector3(0, 0, 0);
        if (backpackState == false)
        { 
            backpackPos = transform.position;
            backpackPos.x = backpackPos.x - slideAmount * Time.deltaTime;
;            transform.position = backpackPos;
            if (gameObject.transform.position.x >= 200)
            {
                gameObject.SetActive(true);
                Debug.Log("InventoryMover");
                backpackState = true;
            }
            
        }
        else
        {
            gameObject.SetActive(false);
            backpackPos.x = -100;
            transform.position = backpackPos;
            Debug.Log("InventoryStopper");
        }
        Debug.Log("Inventory");
    }


}
