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
            gameObject.transform.position = (mousePos / 37.95f) - new Vector3(6.65f, 5f, 0.0f); 
        }
    }
}
