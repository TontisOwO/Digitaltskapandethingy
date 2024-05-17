using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DialogSwapper : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public List <Sprite> sprites;
    public List <bool> swapper;

    public int listCount;
    public int listCap;

    public bool floorIsT;
    public bool floorIsF1;
    public bool floorIsF2;
    public bool floorIsF3;
    public bool dialogBool;
    public bool trueDialog;

    public PositionConstraint positionConstraint;

    public DialogSwapper otherCharacter;
    public SavedData savedData;
    public Movement movement;

    public Transform transformNPC;
    public Transform transformMC;
    public Transform speachBubblePos;

    public void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Player clicked");
            if (listCount < listCap)
            {
                listCount = listCount + 1;
            }
            
            if (swapper[listCount])
            {
                spriteRenderer.enabled = false;

            }
            else
            {
                spriteRenderer.enabled = true;

            }
            spriteRenderer.sprite = sprites[listCount];
            Debug.Log(listCount);

            if (listCount ==  listCap)
            {
                movement.dialog = false;
                
                if (floorIsT)
                {
                    savedData.dialogSpokenT = true;
                }

                if (floorIsF1)
                {
                    savedData.dialogSpokenF1 = true;
                }

                if (floorIsF2)
                {
                    savedData.dialogSpokenF2 = true;
                }

                if (floorIsF3)
                {
                    savedData.dialogSpokenF3 = true;
                }
            }
        }
   
    }


    void Start()
    {
        movement.dialog = dialogBool;

        if (savedData.dialogSpokenT == true && floorIsT)
        {
            listCount = listCap;
            Debug.Log("dialog skipped");
        }

        else if (savedData.dialogSpokenF1 == true && floorIsF1)
        {
            listCount = listCap;
        }

        else if (savedData.dialogSpokenF2 == true && floorIsF2)
        {
            listCount = listCap;
        }

        else if (savedData.dialogSpokenF3 == true && floorIsF3)
        {
            listCount = listCap;
        }

        else
        {
            spriteRenderer.sprite = sprites[listCount];
            Debug.Log("else");
        }

    }

}
