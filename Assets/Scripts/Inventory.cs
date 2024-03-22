using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Vector3 backpackPos;
    public GameObject inventoryPos;
    public bool go = false;
    public bool stop = false;
    public Camera cam;
    public SpriteRenderer sprite;
    public Sprite openBackpack;
    public Sprite closedBackpack;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        if (go)
        {
            go = false;
            stop = false;
        }

        else
        {
            go = true;
            stop = false;
        }
    }

    void OnGUI()
    {
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePos);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.EndArea();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (go && !stop)
        {
            backpackPos.x = cam.transform.position.x + 6;
            inventoryPos.transform.position = backpackPos;
            stop = true;
            sprite.sprite = openBackpack;
        }
        if (!go && !stop)
        {
            backpackPos.x = cam.transform.position.x + 15;
            inventoryPos.transform.position = backpackPos;
            stop = true;
            sprite.sprite = closedBackpack;
        }
    }
}
