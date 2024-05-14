using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;

public class SettingsScript : MonoBehaviour
{
    public SavedData myData;
    public Slider Slider;
    public TMP_Text text;
    public int whatSetting;
    float currentValue;
   
    //link data with settings.
    private void Start()
    {
        Slider.minValue = 10;
        if (whatSetting == 0)
        {
            Slider.value = myData.MusicVolume;
        }
        if (whatSetting == 1)
        {
            Slider.value = myData.SFXVolume;
        }
    }

    //settings for SFX and music.
    public void NoiseSetting(int Volume)
    {
        switch(whatSetting)
        {
            case 0:
                {
                    myData.MusicVolume = Volume;
                    Slider.value = Volume;
                    Slider.maxValue = Volume;
                    break;
                }

            case 1:
                {
                    myData.SFXVolume = Volume;
                    Slider.value = Volume;
                    Slider.maxValue = Volume;
                    break;
                }
        }
    }

    void Update()
    {
        //prevent slider from becoming too small
        currentValue = Slider.value - 10;
        if ( Slider.value < 10)
        {
            Slider.value = 10;
        }
        if (whatSetting == 0)
        {
            myData.MusicVolume = Slider.value;
        }
        if (whatSetting == 1)
        {
            myData.SFXVolume = Slider.value;
        }
        //display current volume
        text.text = currentValue.ToString();
    }
}
