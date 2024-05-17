using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkBubbleClick : MonoBehaviour
{
    public int itemValue;
    public int itemValue2;
    public ThinkBubble ThinkBubble;
    public bool specialcase;
    bool mousedown;
    public void OnMouseDown()
    {
        ThinkBubble.SpriteChange(itemValue);
        mousedown = true;
        Debug.Log("yay");
    }
    void OnMouseUp()
    {
        mousedown = false;
    }
    public void OnMouseOver()
    {
        if (specialcase && !mousedown)
        {
            ThinkBubble.SpriteChange(itemValue2);
        }
    }
}