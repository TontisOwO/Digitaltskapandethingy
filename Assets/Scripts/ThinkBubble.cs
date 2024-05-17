using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkBubble : MonoBehaviour
{
    public List<Sprite> ThinkBubbles;
    public float timeSinceClick;
    public float disappearTime;
    public SpriteRenderer ThinkBubbleRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceClick -= Time.deltaTime;
        if (timeSinceClick < 0) 
        {
            ThinkBubbleRenderer.sprite = null;
        }
    }
    public void SpriteChange(int newSprite)
    {
        ThinkBubbleRenderer.sprite = ThinkBubbles[newSprite];
        timeSinceClick = disappearTime;
    }
}
