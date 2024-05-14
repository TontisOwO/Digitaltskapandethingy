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
    public PositionConstraint positionConstraint;
    public DialogSwapper otherCharacter;
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
        }
   
    }


    void Start()
    {
        listCount = 0;
        spriteRenderer.sprite = sprites[0];
    }
}
