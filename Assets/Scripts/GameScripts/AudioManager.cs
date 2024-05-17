using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public SavedData myData;

    //decide what source plays what SFX
    [Header("------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    //list of our audio clips
    [Header("------- Audio Clip -------")]
    public AudioClip background;
    public AudioClip click;
    public AudioClip planks;
    public AudioClip nails;
    public AudioClip titlemusic;
    public AudioClip zip;
    public AudioClip unzip;

    private void Start()
    {
        //check if title music should be player or if background music should be played
        if (SceneManager.loadedSceneCount == 0)
        {
            musicSource.clip = titlemusic;
            musicSource.Play();
        }
        else
        {
            musicSource.clip = background;
            musicSource.Play();
        }
    }

    public void Update()
    {
        //link volume to data
        musicSource.volume = myData.SFXVolume / 100;
        SFXSource.volume = myData.SFXVolume / 100;

        //play click sound
        if ( Input.GetMouseButtonDown(0))
        {
            SFXSource.clip = click;
            SFXSource.Play();
        }
    }

    //reference for other scripts
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
