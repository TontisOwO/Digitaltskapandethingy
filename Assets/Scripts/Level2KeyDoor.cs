using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2KeyDoor : MonoBehaviour
{
    public SavedData savedData;
    public SceneLoader sceneLoader;
    private void OnMouseDown()
    {
        if (savedData.KeyItem == true)
        {
            sceneLoader.LoadScene(3.ToString());
        }
    }
}
