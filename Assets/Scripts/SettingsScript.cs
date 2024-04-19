using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public SavedData myData;
    public Slider soundSlider;

    private void Start()
    {
        soundSlider.value = myData.GameVolume;
    }
    public void MaxVolume(int Volume)
    {
        myData.GameVolume = Volume;
        soundSlider.value = Volume;
        soundSlider.maxValue = Volume;
    }

    void Update()
    {
        myData.GameVolume = soundSlider.value;
    }
}
