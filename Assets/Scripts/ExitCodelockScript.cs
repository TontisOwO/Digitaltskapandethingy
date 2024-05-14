using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCodelockScript : MonoBehaviour
{
    public SavedData savedData;
    public Basic_Touch_Script door;
    public Movement player;
    void Start()
    {
        if (savedData.exitedPuzzleScene == true && savedData.codelockpuzzle == true)
        {
            door.pickUp = true;
            player.worldMousePos = savedData.CharPos;
            player.wantedPos = savedData.CharPos;
            savedData.codelockpuzzle = false;
            savedData.exitedPuzzleScene = false;
        }
    }

    
    void Update()
    {
        
    }
}
