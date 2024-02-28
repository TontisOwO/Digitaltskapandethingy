using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public BoxCollider2D myBoxCollider;
    public CameraScript CameraScript;
    public Vector3 ScreenMousePos;
    public Vector3 worldMousePos;
    public Vector3 wantedPosition;
    public float movementSpeed = 5.0f;
    public float yMovementSpeedDivideScale = 4.0f;

    void Start()
    {
        worldMousePos = transform.position;
        wantedPosition.z = -1f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            //Get the position of the mouse
            ScreenMousePos = Input.mousePosition;

            //Convert the screen position of the mouse to the world position
            worldMousePos = Camera.main.ScreenToWorldPoint(ScreenMousePos);
            worldMousePos.z = -1; //set the z value to -1
            worldMousePos.y += myBoxCollider.size.y * 0.5f;//line it up with the bottom of the character
            //Top constraint
            if (worldMousePos.y > -1.40f)
            {
                worldMousePos.y = -1.40f;
            }
            //Bottom constraint
            if (worldMousePos.y < -2.55f)
            {
                worldMousePos.y = -2.55f;
            }

            wantedPosition = transform.position;
        }
        wantedPosition.x = Mathf.MoveTowards(wantedPosition.x, worldMousePos.x, movementSpeed * Time.deltaTime);
        wantedPosition.y = Mathf.MoveTowards(wantedPosition.y, worldMousePos.y, (movementSpeed * Time.deltaTime)/yMovementSpeedDivideScale);
        transform.position = wantedPosition;
    }
}
