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
    public Vector3 wantedPosition;
    public float movementSpeed = 5.0f;
    public float yMovementSpeedDivideScale = 4.0f;
    public float maxPosY = -1.40f;
    public float minPosY = -2.55f;
    public float maxPosX = 11.20f;
    public float minPosX = -9.0f;
    public float collisionPrevention = -2.4f;
    

    void Start()
    {
        worldMousePos = transform.position;
        wantedPosition = transform.position;
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
            worldMousePos.y += -myBoxCollider.offset.y + (myBoxCollider.size.y * 0.5f);//line it up with the bottom of the character
            
            //Set max and min for position
            worldMousePos.x = Mathf.Clamp(worldMousePos.x, minPosX, maxPosX);
            worldMousePos.y = Mathf.Clamp(worldMousePos.y, minPosY, maxPosY);

            //if (worldMousePos.x >= 1.06f && worldMousePos.x <= 9.51f)
            //{
            //    worldMousePos.y = Mathf.Clamp(worldMousePos.y, minPosY, collisionPrevention);
            //}
            //if (worldMousePos.x >= -9.98 && worldMousePos.x <= -1.65f)
            //{
            //    worldMousePos.y = Mathf.Clamp(worldMousePos.y, minPosY, collisionPrevention);
            //}
            //if (worldMousePos.x >= 12.07)
            //{
            //    worldMousePos.y = Mathf.Clamp(worldMousePos.y, minPosY, collisionPrevention - 0.48f);
            //}
        }   
        
        //The Slide^TM
        wantedPosition.x = Mathf.MoveTowards(wantedPosition.x, worldMousePos.x, movementSpeed * Time.deltaTime);
        wantedPosition.y = Mathf.MoveTowards(wantedPosition.y, worldMousePos.y, (movementSpeed * Time.deltaTime)/yMovementSpeedDivideScale);
        transform.position = wantedPosition;
        CameraScript.cameraPos = wantedPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Block") == true)
        {
            worldMousePos = wantedPosition;
        }
        else
        {
            worldMousePos.y = transform.position.y;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Block") == true)
        {
            worldMousePos.x = wantedPosition.x * 0.99f;
        }
        else if (collision.gameObject.tag.Equals("Background") == true)
        {
            BoxCollider2D boxCollider = (BoxCollider2D)collision.collider;
            worldMousePos.y = boxCollider.offset.y - (boxCollider.size.y * 0.5f) + (myBoxCollider.size.y * 0.5f) - myBoxCollider.offset.y -0.1f;
        }

    }
}