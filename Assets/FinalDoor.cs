using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    public SavedData savedData;
    public SceneLoader loader;
    public string credits;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (savedData.BuildingKey == true) 
        {
            loader.LoadScene(credits);
        }
    }
}
