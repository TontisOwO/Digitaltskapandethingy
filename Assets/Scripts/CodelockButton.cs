using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodelockButton : MonoBehaviour
{
    public CodelockNumber number1;
    public CodelockNumber number2;
    public CodelockNumber number3;
    public CodelockNumber number4;
    public int buttonNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (number1.pressNumberAmount < 4)
        {
            number1.ButtonPress(buttonNumber);
            number2.ButtonPress(buttonNumber);
            number3.ButtonPress(buttonNumber);
            number4.ButtonPress(buttonNumber);

        }

    }
}
