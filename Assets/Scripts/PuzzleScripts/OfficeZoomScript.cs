using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeZoomScript : MonoBehaviour
{
    public List<Sprite> sprites;
    public SpriteRenderer spriteRend;
    public int sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sprite is set to the sprite in the list with the same number as the sprite int
        spriteRend.sprite = sprites[sprite];
        //close zoomins
        if (sprite != 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                sprite = 0;
                spriteRend.sortingOrder = 0;
            }
        }
    }

    //open calander zoomin
    public void CalanderClick(int number)
    {
        sprite = 4;
        spriteRend.sortingOrder = 10;
    }
    //open trash zoomin
    public void TrashClick(int number)
    {
        sprite = 2;
        spriteRend.sortingOrder = 10;
    }
    //open book zoomin
    public void BookClick(int number)
    {
        sprite = 1;
        spriteRend.sortingOrder = 10;
    }
    //open clock zoomin
    public void ClockClick(int number)
    {
        sprite = number;
        spriteRend.sortingOrder = 10;
    }
}
