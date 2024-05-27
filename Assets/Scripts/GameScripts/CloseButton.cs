using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public SavedData saveData;
    public string scene;
    public bool Specialbutton;
    public bool Startbutton;
    public bool NewGame;
    public bool enterpuzzle;
    public bool floor3Door;
    private void OnMouseDown()
    {
        if (!floor3Door || saveData.floor3PuzzleDone)
        {
            if (!Specialbutton)
            {
                sceneLoader.ExitPuzzleScene(scene);
            }
            else if (Startbutton)
            {
                sceneLoader.ContinueGame();
            }
            else if (NewGame)
            {
                sceneLoader.EraseData();
            }
            else if (enterpuzzle)
            {
                sceneLoader.EnterPuzzleScene(scene);
            }
            else
            {
                sceneLoader.LoadScene(scene);
            }
        }
    }
}
