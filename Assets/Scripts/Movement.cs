using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CameraScript CameraScript;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Debug.Log("The current x position is " + mousePos.x);
            Debug.Log("The current y position is " + mousePos.y);
            
            mousePos.x = (mousePos.x / 37.95f) - 6.65f;
            mousePos.y = (mousePos.y / 379.5f) - 2.45f;
            gameObject.transform.position = mousePos + CameraScript.CameraPos;
        }
    }
}
