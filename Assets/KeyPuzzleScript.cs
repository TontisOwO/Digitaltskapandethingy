using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPuzzleScript : MonoBehaviour
{
    public Camera cam;

    [SerializeField]
    public Transform keyPosition;
    public Vector3 mousePosition;
    public Vector3 usableMousePosition;
    public Vector3 wantedPosition;

    [SerializeField]
    public double minXPos;
    public double maxXPos;

    [SerializeField]
    public double minYPos;
    public double maxYPos;

    [SerializeField]
    public bool canTouchThis;
    public bool touchingWithMouse;

    void Start()
    {
        cam = Camera.main;

        Debug.Log("Start");
        minXPos = wantedPosition.x - 0.1;
        maxXPos = wantedPosition.x + 0.1;

        minYPos = wantedPosition.y - 0.1;
        maxYPos = wantedPosition.y + 0.1;
    }

    // Update is called once per frame
    void Update()
    {
        
        mousePosition = Input.mousePosition;
        usableMousePosition = cam.ScreenToWorldPoint(mousePosition);
        usableMousePosition.z = 0;

        if ((keyPosition.position.x > minXPos) && (keyPosition.position.x < maxXPos))
        {
            transform.position = wantedPosition;
            canTouchThis = false;
            Debug.Log("Snap");
        }



        if (canTouchThis)
        {
            

            if (touchingWithMouse)
            {
                transform.position = usableMousePosition;
                Debug.Log("Move");
            }

        }

    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        if (touchingWithMouse) 
        { 
            touchingWithMouse = false;
            Debug.Log("Touching Mouse");
        }

        if (!touchingWithMouse && canTouchThis)
        {
            touchingWithMouse = true;
            Debug.Log("Not Touching Mouse");
        }

        

    }

    //Copy pasted thing to make mouse position a world position


}
