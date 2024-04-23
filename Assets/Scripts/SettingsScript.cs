using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public SavedData myData;
    public Slider musicSlider;
    public Slider SFXSlider;

    private void Start()
    {
        musicSlider.value = myData.MusicVolume;
        SFXSlider.value = myData.SFXVolume;
    }
    public void MaxMusicVolume(int Volume)
    {
        myData.MusicVolume = Volume;
        musicSlider.value = Volume;
        musicSlider.maxValue = Volume;
    }

    public void MaxSFXVolume(int Volume)
    {
        myData.SFXVolume = Volume;
        SFXSlider.maxValue = Volume;
        SFXSlider.value = Volume;
    }

    void Update()
    {
        myData.MusicVolume = musicSlider.value;
        myData.SFXVolume = SFXSlider.value;
    }
}
