using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class GlassMovement : MonoBehaviour
{
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 1;
        if (transform.position.z != 1)
        {

        }    
    }

    void OnMouseDrag()
    {
        transform.position = mousePos;
    }
}
