using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class OfficeClickScript : MonoBehaviour
{
    public Vector3 mousePos;
    public GameObject Selecter;
    public OfficeZoomScript zoomScript;
    public string whatObject;
    int Object;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            zoomScript.sprite = Object;
        }
    }

    public void ObjectDoPlease()
    {
        switch (whatObject)
        {
            case "Book":
                {
                    Object = 1;
                    break;
                }
            case "Trash":
                {
                    Object = 2;
                    break;
                }
            case "Clock":
                {
                    Object = 3;
                    break;
                }
            case "Calander":
                {
                    Object = 4;
                    break;
                }
        }
    }
}
