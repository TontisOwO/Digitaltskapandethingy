using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor3PuzzleScript : MonoBehaviour
{
    public KeyPuzzleScript redKey;
    public KeyPuzzleScript greenKey;
    public KeyPuzzleScript blueKey;
    public SavedData saveData;
    public SceneLoader sceneLoader;

    // Update is called once per frame
    void Update()
    {
        
        if (!redKey.canTouchThis && !greenKey.canTouchThis && !blueKey.canTouchThis)
        {
            Debug.Log("PuzzleCheck");
            saveData.floor3PuzzleDone = true;
            sceneLoader.ExitPuzzleScene("3");
        }
    }
}
