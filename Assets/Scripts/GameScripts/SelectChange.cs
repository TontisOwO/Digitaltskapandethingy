using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChange : MonoBehaviour
{
    public List<Sprite> spriteSelect;
    public SpriteRenderer spriteRenderer;
    public int currentSprite;
    public bool typewriter =false;
    public bool typewriterClick = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    private void OnMouseOver()
    {
        currentSprite = 1;
            if(spriteSelect.Count > 2 && Input.GetKey(KeyCode.Mouse0)) 
            {
                if (typewriter)
                {
                currentSprite = 2;
                typewriterClick = true;
                }

                currentSprite = 2;
            }
    }
    void Update()
    {
        if (typewriterClick == true)
        {
            currentSprite = 2;
        }
        spriteRenderer.sprite = spriteSelect[currentSprite];

    }
    private void OnMouseExit()
    {
        currentSprite = 0;
    }
}
