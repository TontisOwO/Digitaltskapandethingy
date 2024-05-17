using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodelockNumber : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public int pressNumberAmount;
    public int numberPos;
    public int pressedNumber;
    public List<Sprite> Number;
    public int correctNumber;
    public CodelockNumber otherNumber1;
    public CodelockNumber otherNumber2;
    public CodelockNumber otherNumber3;
    public float pressTime;
    public SceneLoader sceneLoader;
    public SavedData savedData;
    void Start()
    {
        
    }

    void Update()
    {
        spriteRenderer.sprite = Number[pressedNumber - 1];
        pressTime -= Time.deltaTime;
        if (pressNumberAmount >= 4 &&
            !(pressedNumber == correctNumber &&
            otherNumber1.pressedNumber == otherNumber1.correctNumber &&
            otherNumber2.pressedNumber == otherNumber2.correctNumber &&
            otherNumber3.pressedNumber == otherNumber3.correctNumber) &&
            pressTime <= 0f)
        {
            pressedNumber = 10;
            pressNumberAmount = 0;
        }
        else if(pressedNumber == correctNumber &&
            otherNumber1.pressedNumber == otherNumber1.correctNumber &&
            otherNumber2.pressedNumber == otherNumber2.correctNumber &&
            otherNumber3.pressedNumber == otherNumber3.correctNumber &&
            pressTime <= 0f)
        {
            sceneLoader.ExitPuzzleScene(2.ToString());
            savedData.codelockpuzzle = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sceneLoader.ExitPuzzleScene(2.ToString());
        }
    }
    public void ButtonPress(int num)
    {
        pressTime = 0.5f;
        if (pressNumberAmount == numberPos) 
        {
            pressedNumber = num;
        }
        pressNumberAmount = pressNumberAmount + 1;
        
    }
    
}
