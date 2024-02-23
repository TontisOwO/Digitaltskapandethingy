using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class Movement : MonoBehaviour
{
    public CameraScript CameraScript;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the position of the mouse
            Vector3 ScreenMousePos = Input.mousePosition;

            //Convert the screen position of the mouse to the world position
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(ScreenMousePos);
            worldMousePos.z = -1; //set the z value to -1
            
            //Top constraint
            if (worldMousePos.y > -1.40f)
            {
                worldMousePos.y = -1.40f;
            }
            //Bottom constraint
            if (worldMousePos.y < -2.50f)
            {
                worldMousePos.y = -2.50f;
            }

            gameObject.transform.position = worldMousePos;
        }
    }
}
