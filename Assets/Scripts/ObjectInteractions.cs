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
    //Reference to the item being used
    public bool ItemDestroyed;
    //The item being interacted with
    public GameObject ItemInteracted = null;
    //What should happen upon interaction
    public int EventUponInt;
    //Item being used
    public int UsedItem;
    bool ItUs;
    //Reference to ItemChange event
    public int NewItem;
    bool NwIt;
    //The scene that should be loaded
    public string SceneName = "Adonai's Work Place";

    void Start()
    {

    }

    private void Update()
    {
        //Check what item is being used
        switch(UsedItem)
        {
            case 0:
                {
                    ItUs = true;
                    break;
                }
            case 1:
                {
                    ItUs = myData.KeyItem;
                    if (myData.KeyItem == true)
                    {
                        ItUs = true;
                    }
                    break;
                }
            case 2:
                {
                    ItUs = myData.AxeItem;
                    if (myData.AxeItem == true)
                    {
                        ItUs = true;
                    }
                    break;
                }
            case 3:
                {
                    ItUs = myData.MatchItem;
                    if (myData.MatchItem == true)
                    {
                        ItUs = true;
                    }
                    break;
                }
            case 4:
                {
                    ItUs = myData.CrubrItem;
                    if (myData.CrubrItem == true)
                    {
                        ItUs = true;
                    }
                    break;
                }
        }

        //Check what new item should be added
        switch(NewItem)
        {
            case 1:
                {
                    myData.KeyItem = NwIt;
                    NwIt = myData.KeyItem;
                    break;
                }
            case 2:
                {
                    myData.AxeItem = NwIt;
                    NwIt = myData.AxeItem;
                    break;
                }
            case 3:
                {
                    myData.MatchItem = NwIt;
                    NwIt = myData.MatchItem;
                    break;
                }
            case 4:
                {
                    myData.CrubrItem = NwIt;
                    NwIt = myData.CrubrItem;
                    break;
                }
        }
    }

    public void ButtonPressed()
    {
        if(ItUs == true)
        {
            switch(EventUponInt)
            {
                case 1:
                    {
                        GameObject.Destroy(ItemInteracted);
                        break;
                    }   
                case 2:
                    {
                        GameObject.Destroy(ItemInteracted);
                        ItUs = false;
                        NwIt = true;
                        break;
                    }
                case 3:
                    {
                        SceneManager.LoadScene(SceneName);
                        break;
                    }
            }
        }
    }

    public void ItemDestruction()
    {
        if (ItemDestroyed == true)
        {
            ItUs = false;
        }
    }
}
