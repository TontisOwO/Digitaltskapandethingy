using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextManipulation : MonoBehaviour
{
    public Basic_Touch_Script touch_Script;
    public bool mouseExit;
    public bool mouseOver;
    public bool mouseDown;
    public TextMeshProUGUI text;
    public TextMeshProUGUI touchText;
    public Color colour;
    public Color newColour;
    public float fadeSpeed;

    // Update is called once per frame
    void Update()
    {
        if (mouseExit)
        {
            FadeTextToZeroAlpha(1f, text);
        }
        if (mouseOver)
        {
            text.color = newColour;
        }
    }

    public void FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {

        if (mouseOver)
        {
            colour.a = 1.0f;
        }
        else
        {
            colour.a -= fadeSpeed * Time.deltaTime;
        }

        text.color = new Color(text.color.r, text.color.g, text.color.b, colour.a);
    }
}


