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
    //Tag to prevent colliding with everything
    public string objectText;
    public Vector3 mousePos;
    public float whatGoal;
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

    

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GoalScript goalComp = collision.gameObject.GetComponent<GoalScript>();

        if (goalComp != null)
        {
            if (goalComp.gameObject.tag.Equals(objectText) == true)
            {
                Debug.Log("hihihi");
                inPlace = true;
            }
            if (goalComp.gameObject.tag.Equals(objectText) == false)
            {
                Debug.Log("hohoho");
                inPlace = false;
            }
        }
    }

}
