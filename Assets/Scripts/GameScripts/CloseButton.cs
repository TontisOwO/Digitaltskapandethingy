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
        else
        {
            sceneLoader.LoadScene(scene);
        }
    }
}
