using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "SavedData", menuName = "OUR STUFF")]

public class SavedData : ScriptableObject
{
    private ObjectInteractions ItemUsage;
    public int CurrentFloor = 1;
    private int MaxFloor = 4;
    private int MinFloor = 1;

    //Sample Item
    public bool SampleItem = false;
    //Key Item
    public bool KeyItem = false;
    //Axe Item
    public bool AxeItem = false;
    //Match Item
    public bool MatchItem = false;
    //Crubr Item
    public bool CrubrItem = false;

    public void Update()
    {
        if (CurrentFloor <= MinFloor)
        {
            CurrentFloor = 1;
        }
        if (CurrentFloor >= MaxFloor) 
        {
            CurrentFloor = 4;
        }
    }
}
