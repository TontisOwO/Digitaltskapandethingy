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
    private int MinFloor = 0;
    public float GameVolume;

    //Sample Item
    public bool SampleItem;
    //Key Item
    public bool KeyItem;
    //Axe Item
    public bool AxeItem;
    //Match Item
    public bool MatchItem;
    //Crubr Item
    public bool CrubrItem;

    public Vector3 NPCPos;
    public Vector3 CharPos;

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
