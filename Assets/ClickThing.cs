using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickThing : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public OfficeZoomScript background;
    public int light;
    public int dark;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (background.sprite == 0)
        {
            SpriteRenderer.sortingOrder = light;
        }
        else
        {
            SpriteRenderer.sortingOrder = dark;
        }
    }
}