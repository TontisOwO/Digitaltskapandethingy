using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public SavedData myData = null;
    public int ItemCount = 0;
    public int MaxItems = 4;
    public int MinItems = 0;
    private bool ItemOne = false;
    private bool ItemTwo = false;
    private bool ItemThree = false;
    private bool ItemFour = false;


    void Start()
    {
        
    }

    private void Update()
    {
        //Key
        if (myData.KeyItem == true)
        {
            if (ItemOne == false)
            {
                myData.KeyItem = ItemOne;
                ItemOne = true;
                ItemCount += 1;
            }
            else
            if (ItemOne == true)
            {
                myData.KeyItem = ItemTwo;
                ItemTwo = true;
                ItemCount += 1;
            }
            else
            if (ItemTwo == true)
            {
                myData.KeyItem = ItemThree;
                ItemThree= true;
                ItemCount += 1;
            }
            else
            if (ItemThree == true)
            {
                myData.KeyItem = ItemFour;
                ItemFour = true;
                ItemCount += 1;
            }
        }
        //Axe
        if (myData.AxeItem == true)
        {
            ItemCount += 1;
            if (ItemOne == false)
            {
                myData.AxeItem = ItemOne;
                ItemOne = true;
                ItemCount += 1;
            }
            else
            if (ItemOne == true)
            {
                myData.AxeItem = ItemTwo;
                ItemTwo = true;
                ItemCount += 1;
            }
            else
            if (ItemTwo == true)
            {
                myData.AxeItem = ItemThree;
                ItemThree = true;
                ItemCount += 1;
            }
            else
            if (ItemThree == true)
            {
                myData.AxeItem = ItemFour;
                ItemFour = true;
                ItemCount += 1;
            }
        }
        //Match
        if (myData.MatchItem == true)
        {
            ItemCount += 1;
            if (ItemOne == false)
            {
                myData.MatchItem = ItemOne;
                ItemOne = true;
                ItemCount += 1;
            }
            else
            if (ItemOne == true)
            {
                myData.MatchItem = ItemTwo;
                ItemTwo = true;
                ItemCount += 1;
            }
            else
            if (ItemTwo == true)
            {
                myData.MatchItem = ItemThree;
                ItemThree = true;
                ItemCount += 1;
            }
            else
            if (ItemThree == true)
            {
                myData.MatchItem = ItemFour;
                ItemFour = true;
                ItemCount += 1;
            }
        }
        //CrowBar
        if (myData.CrubrItem == true)
        {
            ItemCount += 1;
            if (ItemOne == false)
            {
                myData.CrubrItem = ItemOne;
                ItemOne = true;
                ItemCount += 1;
            }
            else
            if (ItemOne == true)
            {
                myData.CrubrItem = ItemTwo;
                ItemTwo = true;
                ItemCount += 1;
            }
            else
            if (ItemTwo == true)
            {
                myData.CrubrItem = ItemThree;
                ItemThree = true;
                ItemCount += 1;
            }
            else
            if (ItemThree == true)
            {
                myData.CrubrItem = ItemFour;
                ItemFour = true;
                ItemCount += 1;
            }
        }

    }

    void DropItems()
    {
        
    }
}
