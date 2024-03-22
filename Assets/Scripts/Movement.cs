using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public BoxCollider2D myBoxCollider;
    public CameraScript CameraScript;
    public Vector3 ScreenMousePos;
    public Vector3 worldMousePos;
    public Vector3 wantedPos;
    public float xMovementSpeed = 5.0f;
    public float yMovementSpeed = 4.0f;
    public float movementSpeedOrigin;
    public float maxPosY = -1.40f;
    public float minPosY = -2.55f;
    public float maxPosX = 11.20f;
    public float minPosX = -9.0f;

    void Start()
    {
        movementSpeedOrigin = xMovementSpeed;
        yMovementSpeed = xMovementSpeed / 4;
        worldMousePos = transform.position;
        wantedPos = transform.position;
        wantedPos.z = -1f;
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

            //set the z value to -1
            worldMousePos.z = -1;

            //line y up with the bottom of the character
            worldMousePos.y += -myBoxCollider.offset.y + (myBoxCollider.size.y * 0.5f);
            
            //Set max and min for position
            worldMousePos.x = Mathf.Clamp(worldMousePos.x, minPosX, maxPosX);
            worldMousePos.y = Mathf.Clamp(worldMousePos.y, minPosY, maxPosY);
        }   
        
        //The Slide^TM
        wantedPos.x = Mathf.MoveTowards(wantedPos.x, worldMousePos.x, xMovementSpeed * Time.deltaTime);
        wantedPos.y = Mathf.MoveTowards(wantedPos.y, worldMousePos.y, yMovementSpeed * Time.deltaTime);
        transform.position = wantedPos;
        CameraScript.cameraPos = wantedPos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Block") == true)
        {
            worldMousePos = wantedPos;
        }
        else
        {
            worldMousePos.y = transform.position.y;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        BoxCollider2D boxCollider = (BoxCollider2D)collision.collider;
        if (collision.gameObject.tag.Equals("Block") == true)
        {
            if (transform.position.x > collision.transform.position.x)
            {
                worldMousePos.x = wantedPos.x + xMovementSpeed * Time.deltaTime;
            }
            else
            {
                worldMousePos.x = wantedPos.x - xMovementSpeed * Time.deltaTime;
            }

        }
        else if (collision.gameObject.tag.Equals("Background") == true)
        {
            worldMousePos.y = boxCollider.offset.y - (boxCollider.size.y * 0.5f)
                 - boxCollider.edgeRadius + (myBoxCollider.size.y * 0.5f)
                 - myBoxCollider.offset.y - 0.1f;
            //worldMousePos.y = ;
            xMovementSpeed = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        xMovementSpeed = movementSpeedOrigin;
    }
}