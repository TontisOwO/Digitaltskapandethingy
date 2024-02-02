using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteractions : MonoBehaviour
{
    //Reference to playerdata
    public SavedData myData = null;
    //Reference to the item being used
    private bool ItemUsed;
    public bool ItemDestroyed = false;
    //The item being interacted with
    public GameObject ItemInteracted = null;
    //What should happen upon interaction
    public bool ObstacleRemoval = false;
    public bool ItemChange = false;
    public bool FloorEnd = false;
    //Item being used
    public bool IsKeyItem = false;
    public bool IsAxeItem = false;
    public bool IsMatchItem = false;
    //Reference to ItemChange event
    private bool NewItem;
    public bool NewItemKey = false;
    public bool NewItemAxe = false;
    public bool NewItemMatch = false;
    //The scene that should be loaded
    public string SceneName = "Adonai's Work Place";

    void Start()
    {

    }

    private void Update()
    {
        //Check what item is being used
        if (IsKeyItem == true)
        {
            ItemUsed = myData.KeyItem;
            myData.KeyItem = ItemUsed;
        }
        else
        if (IsAxeItem == true)
        {
            ItemUsed = myData.AxeItem;
            myData.AxeItem = ItemUsed;
        }
        else
        if (IsMatchItem == true)
        {
            ItemUsed = myData.MatchItem;
            myData.MatchItem = ItemUsed;
        }

        //Check what new item should be added
        if (NewItemKey == true)
        {
            NewItem = myData.KeyItem;
            myData.KeyItem = NewItem;
        }
        else
        if (NewItemAxe == true)
        {
            NewItem = myData.AxeItem;
            myData.AxeItem = NewItem;
        }
        else
        if (NewItemMatch == true)
        {
            NewItem = myData.MatchItem;
            myData.MatchItem = NewItem;
        }
    }

    public void ButtonPressed()
    {
        if (ItemUsed == true)
        {
            if (ObstacleRemoval == true)
            {
                GameObject.Destroy(ItemInteracted);
            }
            else
            if (ItemChange == true)
            {
                GameObject.Destroy(ItemInteracted);
                NewItem = true;
            }
            else
            if (FloorEnd == true)
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }

    public void ItemDestruction()
    {
        if (ItemDestroyed == true)
        {

        }
    }
}
