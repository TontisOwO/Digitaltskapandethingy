using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "SavedData", menuName = "OUR STUFF")]

public class SavedData : ScriptableObject
{
    private ObjectInteractions ItemUsage;
    public int Floor = 3;

    public bool SampleItem = false;
    public bool KeyItem = false;
    public bool AxeItem = false;
    public bool MatchItem = false;

}
