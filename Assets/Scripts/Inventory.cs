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
