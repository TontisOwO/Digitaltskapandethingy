using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeClickScript : MonoBehaviour
{
    public Vector3 mousePos;
    public GameObject Selecter;
    public OfficeZoomScript zoomScript;
    public SceneLoader sceneLoader;
    public int whatObject;
    public bool Box = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonUp(0))
        {
            zoomScript.sprite = 0;

        }
    }

    void OnMouseOver()
    {
            if (Input.GetMouseButtonDown(0))
            {
            if (Box == true)
            {
                sceneLoader.LoadScene("PuzzleBox");
                return;
            }
                zoomScript.sprite = whatObject;
            }       
    }
}
