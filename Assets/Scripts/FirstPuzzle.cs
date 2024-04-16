using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPuzzle : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public bool condition;
    public bool firstPlank;
    public bool secondPlankCheck;
    public FirstPuzzle secondPlank;
    public Basic_Touch_Script door;

    public float spikesCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spikesCount >= 2)
        {
            if (condition == true)
            {
                rigidBody.gravityScale = 1.5f;
                if (firstPlank == true)
                {
                    secondPlank.condition = true;
                }
                if (secondPlankCheck == true)
                {
                    door.itemCondition = true;
                }
            }

        }
    }
}
