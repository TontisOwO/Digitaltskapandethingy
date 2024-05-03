using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class GlassScript : MonoBehaviour
{
    public bool inPlace = false;
    public string Goal;
    public Vector3 mousePos;
    private void Start()
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

    

    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals(Goal) == true)
        {
            Debug.Log("hihihi");
            inPlace = true;
        }
    }

}
