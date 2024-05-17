using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChange : MonoBehaviour
{
    public List<Sprite> spriteSelect;
    public SpriteRenderer spriteRenderer;
    public int currentSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     spriteRenderer.sprite = spriteSelect[currentSprite];
    }
    private void OnMouseOver()
    {
        currentSprite = 1;
            if(spriteSelect.Count > 2 && Input.GetKey(KeyCode.Mouse0)) 
            {
                currentSprite = 2;
            }
    }
    private void OnMouseExit()
    {
        currentSprite = 0;
    }
}
