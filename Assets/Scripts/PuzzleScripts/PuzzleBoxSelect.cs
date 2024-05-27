using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBoxSelect : MonoBehaviour
{
    public List<Sprite> Button;
    public List<Sprite> Number;
    public SpriteRenderer Buttons;
    public SpriteRenderer Numbers;
    public int ButtonPhase;
    public int NumberPhase;
    public int NumberCorrect;
    public bool hovering;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Numbers.sprite = Number[NumberPhase];
    }
    public void OnMouseOver()
    {
        hovering = true;
        ButtonPhase = 0;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            ButtonPhase = 1;
        }
        Buttons.sprite = Button[ButtonPhase];
    }
    private void OnMouseExit()
    {
        hovering = false;
    }
    public void OnMouseDown()
    {
        NumberPhase = NumberPhase + 1;
        if (NumberPhase > 8)
        {
            NumberPhase = 0;
        }
    }
}
