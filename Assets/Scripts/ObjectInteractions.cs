using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum ItemUseCases
{
    UseDestroy = 0, 
    UseDestroyAndGetNew = 1,
    LoadScene = 2,
    Total,

}

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
    public bool ItUs = true;
    public int UsedItem;

    //Reference to ItemChange event
    public int NewItem;
    public bool NwIt = true;
    //The scene that should be loaded
    public string SceneName = "Adonai's Work Place";

    void Start()
    {

    }

    private void Update()
    {

    }

    public void ButtonPressed()
    {
        if(ItUs == true)
        {
            switch((ItemUseCases)EventUponInt)
            {
                //Destroy obstacle
                case ItemUseCases.UseDestroy:
                    {
                        UseItemMethod();
                        GameObject.Destroy(ItemInteracted);
                        break;
                    }
                //Get new item
                case ItemUseCases.UseDestroyAndGetNew:
                    {
                        UseItemMethod();
                        GameObject.Destroy(ItemInteracted);
                        NwIt = true;
                        break;
                    }
                //Load scene
                case ItemUseCases.LoadScene:
                    {
                        UseItemMethod();
                        SceneManager.LoadScene(SceneName);
                        break;
                    }
            }
        }
    }

    private void UseItemMethod()
    {
        //What item is being used
        switch (UsedItem)
        {
            case 0:
                {
                    ItUs = true;
                    break;
                }
            case 1:
                {
                    ItUs = false;
                    myData.KeyItem = ItUs;
                    break;
                }
            case 2:
                {
                    ItUs = false;
                    myData.AxeItem = ItUs;
                    break;
                }
            case 3:
                {
                    ItUs = false;
                    myData.MatchItem = ItUs;
                    break;
                }
            case 4:
                {
                    ItUs = false;
                    myData.CrubrItem = ItUs;
                    break;
                }
        }
        //What is the new item
        switch (NewItem)
        {
            case 0:
                {
                    NwIt = false;
                    break;
                }
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

        if (NwIt == true)
        {
            ItUs = false;
        }
    }

    //Destroy old item
    public void ItemDestruction()
    {
        if (ItemDestroyed == true)
        {
            UseItemMethod();
            ItUs = false;
        }
    }
}
