using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteractions : MonoBehaviour
{
    //Reference to playerdata and inventory
    public SavedData myData = null;
    public InventoryScript myInv = null;
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
    public bool IsCrubrItem = false;
    //Reference to ItemChange event
    private bool NewItem;
    public bool NewItemKey = false;
    public bool NewItemAxe = false;
    public bool NewItemMatch = false;
    public bool NewItemCrubr = false;
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
        else
        if (IsCrubrItem == true)
        {
            ItemUsed = myData.CrubrItem;
            myData.CrubrItem = ItemUsed;
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
        else
        if (NewItemCrubr == true)
        {
            NewItem = myData.CrubrItem;
            myData.CrubrItem = NewItem;
        }
    }

    public void ButtonPressed()
    {
        //Does the player have the required item?
        if (ItemUsed == true)
        {
            if (ObstacleRemoval == true)
            {
                GameObject.Destroy(ItemInteracted);
            }
            else
            if (ItemChange == true)
            {
                if (myInv.ItemCount < myInv.MaxItems)
                {
                    GameObject.Destroy(ItemInteracted);
                    NewItem = true;
                }
                else
                //Do not allow item pick up if the player's inventory is full
                if (myInv.ItemCount >= myInv.MaxItems)
                {
                    NewItem = false;
                    ItemDestroyed = false;
                }
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
            if (ItemUsed == IsKeyItem)
            {
                myData.KeyItem = false;
            }

            if (ItemUsed == IsAxeItem)
            {
                myData.AxeItem = false;
            }

            if (ItemUsed == IsMatchItem)
            {
                myData.MatchItem = false;
            }

            if (ItemUsed == IsCrubrItem)
            {
                myData.CrubrItem = false;
            }
        }
    }
}
