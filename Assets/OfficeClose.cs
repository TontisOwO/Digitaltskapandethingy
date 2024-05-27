using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeClose : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public OfficeZoomScript background;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (background.sprite == 0) 
        {
        SpriteRenderer.sortingOrder = -500;
            SpriteRenderer.sortingLayerName = "Default";
        }
        else
        {
            SpriteRenderer.sortingOrder = 500;
            SpriteRenderer.sortingLayerName = "OnTop";
        }
    }
    private void OnMouseDown()
    {
        background.sprite = 0;
    }
}

