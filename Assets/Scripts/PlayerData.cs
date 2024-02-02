using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    public int Floor = 3;

    public bool SampleItem = false;
    public bool KeyItem = false;
    public bool AxeItem = false;
    public bool MatchItem = false;
}
