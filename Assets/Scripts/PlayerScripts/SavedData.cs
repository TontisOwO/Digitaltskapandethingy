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
    
    public float MusicVolume;
    public float SFXVolume;
    
    public bool inMenu;
    public bool dialogSpokenT = false;
    public bool dialogSpokenF1 = false;
    public bool dialogSpokenF2 = false;
    public bool dialogSpokenF3 = false;

    //Sample Item
    public bool SampleItem;
    //Key Item
    public bool KeyItem;
    //Color Key Item
    public bool colorKey;
    //Axe Item
    public bool AxeItem;
    //Match Item
    public bool MatchItem;
    //Crubr Item
    public bool CrubrItem;

    public Vector3 NPCPos; //CurrentPos
    public Vector3 CharPos; //WantedPos
    public bool exitedPuzzleScene = false;
    public bool codelockpuzzle = false;
    public bool OpenedBox;
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
