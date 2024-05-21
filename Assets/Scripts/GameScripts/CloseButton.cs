using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public string scene;
    public bool Specialbutton;
    public bool Startbutton;
    public bool NewGame;
    public bool enterpuzzle;
    private void OnMouseDown()
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
