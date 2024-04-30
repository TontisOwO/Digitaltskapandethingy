using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public SavedData myData;

    [Header("------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

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
        musicSource.volume = myData.SFXVolume / 100;
        SFXSource.volume = myData.SFXVolume / 100;

        if ( Input.GetMouseButtonDown(0))
        {
            SFXSource.clip = click;
            SFXSource.Play();
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
