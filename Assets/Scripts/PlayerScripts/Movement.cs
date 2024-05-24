using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public BoxCollider2D myBoxCollider;
    public CameraScript CameraScript;
    public Animator myAnimator;
    public Vector3 ScreenMousePos;
    public Vector3 worldMousePos;
    public Vector3 wantedPos;
    public Vector2 ScreenWorldPoint;
    public float xMovementSpeed = 5.0f;
    public float yMovementSpeed = 4.0f;
    public float movementSpeedOrigin;
    public float maxPosY = -1.40f;
    public float minPosY = -2.55f;
    public float maxPosX = 11.20f;
    public float minPosX = -9.0f;
    public Vector3 facingRight;
    public Vector3 facingLeft;
    public bool dialog = false;
    public SavedData playerData;
    public Basic_Touch_Script door;
    public NPCScript NPC;
    public AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        movementSpeedOrigin = xMovementSpeed;
        yMovementSpeed = xMovementSpeed / 4;
        worldMousePos = transform.position;
        wantedPos = transform.position;
        wantedPos.z = -1f;
        worldMousePos.z = -1f;
        facingRight = transform.localScale;
        facingLeft = transform.localScale;
        facingLeft.x = -transform.localScale.x;
        if (playerData.exitedPuzzleScene == true)
        {
            worldMousePos = playerData.CharPos;
            wantedPos = playerData.CharPos;
            NPC.currentPos = playerData.NPCPos;
            if (playerData.codelockpuzzle == true)
            {
                door.pickUp = true;
                playerData.codelockpuzzle = false;

            }
            playerData.exitedPuzzleScene = false;
        }

       

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Get the position of the mouse
            ScreenMousePos = Input.mousePosition;
            
            //Are you in a dialog?
            if (dialog == false)
            {
                //Check what was clicked
                Vector2 clickPos = Camera.main.ScreenToWorldPoint(ScreenMousePos);
                Collider2D hitCollider = Physics2D.OverlapPoint(clickPos);
                if (hitCollider != null &&

                    //Things that we exclude movement from
                    (hitCollider.CompareTag("GUI") || hitCollider.CompareTag("Player")))
                {

                }
                else
                {
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
            }
            
        }   
        
        //The Slide^TM
        wantedPos.x = Mathf.MoveTowards(wantedPos.x, worldMousePos.x, xMovementSpeed * Time.deltaTime);
        wantedPos.y = Mathf.MoveTowards(wantedPos.y, worldMousePos.y, yMovementSpeed * Time.deltaTime);
        transform.position = wantedPos;
        CameraScript.cameraPos = wantedPos;
        if (wantedPos != worldMousePos)
        {
            myAnimator.SetBool("IsWalking", true);
            audioManager.PlaySFX(audioManager.walking);
        }
        else
        {
            myAnimator.SetBool("IsWalking", false);
            audioManager.PlaySFX(audioManager.walking);
        }
        if (wantedPos.x < worldMousePos.x)
        {
            transform.localScale = facingRight;
        }
        if (wantedPos.x > worldMousePos.x)
        {
            transform.localScale = facingLeft;
        }
        
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
            worldMousePos.y = transform.position.y - yMovementSpeed*Time.deltaTime;
            xMovementSpeed = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        xMovementSpeed = movementSpeedOrigin;
    }
}