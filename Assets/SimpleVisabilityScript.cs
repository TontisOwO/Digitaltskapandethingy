using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleVisabilityScript : MonoBehaviour
{
    public SavedData data;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (data.floor3PuzzleDone)
        {
            gameObject.SetActive(true);
        }
    }
}
