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
            //Get the Position of the mouse
            Vector3 mousePos = Input.mousePosition;
            Debug.Log("The current x position is " + mousePos.x);
            Debug.Log("The current y position is " + mousePos.y);

            //Scale the mouse correctly so it matches the camera
            mousePos.x = (mousePos.x / 34.25f) - 8.8f;
            mousePos.y = (mousePos.y / 379.5f) - 2.45f;

            //Set the position of the character to scaled mouse and adjust for camera position
            gameObject.transform.position = mousePos + CameraScript.CameraPos;
        }
    }
}
