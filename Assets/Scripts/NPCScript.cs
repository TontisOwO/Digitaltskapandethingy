using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public Animator myAnimator;
    public Vector3 wantedPos;
    public Vector3 currentPos;
    public float xMoveSpeed;
    public float yMoveSpeed;
    public GameObject MainCharacter;
    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator.SetBool("isMoving", false);
        yMoveSpeed = xMoveSpeed / 4;
        currentPos = transform.position;
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPos != wantedPos)
        {
            currentPos.x = Mathf.MoveTowards(currentPos.x, wantedPos.x, xMoveSpeed * Time.deltaTime);
            currentPos.y = Mathf.MoveTowards(currentPos.y, wantedPos.y, yMoveSpeed * Time.deltaTime);
            transform.position = currentPos;
            myAnimator.SetBool("isMoving", true);
        }
        else
        {
            myAnimator.SetBool("isMoving", false);
        }
        if (wantedPos.x < currentPos.x)
        {
            scale.x = -0.6f;
        }
        else if (wantedPos.x > currentPos.x)
        {
            scale.x = 0.6f;
        }
        else if (MainCharacter.transform.position.x < currentPos.x)
        {
            scale.x = -0.6f;
        }
        else
        {
            scale.x = 0.6f;
        }
        transform.localScale = scale;
    }
}