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
    public GameObject MoveTool;
    public float whatGoal;
    private void Start()
    {

    }

    public void Update()
    {
        this.transform.position = MoveTool.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GoalScript goalComp = collision.gameObject.GetComponent<GoalScript>();

        if (goalComp != null)
        {
            if (goalComp.gameObject.tag.Equals(objectText) == true)
            {
                inPlace = true;
            }
            if (goalComp.gameObject.tag.Equals(objectText) == false)
            {
                inPlace = false;
            }
        }
    }

}
