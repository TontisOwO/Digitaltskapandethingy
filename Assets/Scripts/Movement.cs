using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            { 
                Debug.Log("The current x position is " + mousePos.x);
                Debug.Log("The current y position is " + mousePos.y);
            }
        }
    }
}
