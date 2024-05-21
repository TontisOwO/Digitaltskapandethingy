using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeZoomScript : MonoBehaviour
{
    public List<Sprite> sprites;
    public SpriteRenderer spriteRend;
    public int sprite = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spriteRend.sprite = sprites[sprite];
        if (spriteRend.sprite != sprites[0])
        {
            spriteRend.sortingLayerName = "OnTop";
        }
        //close zoomins
        if (sprite == 0)
        {
            spriteRend.sortingLayerName = "Default";
        }
    }
}
