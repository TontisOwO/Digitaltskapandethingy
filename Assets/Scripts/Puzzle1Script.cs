using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Script : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public string scene = "1";

    private void OnMouseDown()
    {
        sceneLoader.LoadScene(scene);
    }

}
