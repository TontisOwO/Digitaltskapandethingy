using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public string scene;
    private void OnMouseDown()
    {
        sceneLoader.ExitPuzzleScene(scene);
    }
}
