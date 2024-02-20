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
    public Color alpha;

    // Update is called once per frame
    void Update()
    {
        if (mouseExit)
        {
            StartCoroutine(FadeTextToZeroAlpha(1f, text));
        }
        if (mouseOver)
        {
            alpha.a = 1;
            text.color = alpha;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, alpha.a);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (t * Time.deltaTime));
            yield return null;
        }
        mouseExit = false;
    }
}