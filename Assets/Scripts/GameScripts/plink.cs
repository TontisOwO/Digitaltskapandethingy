using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plink : MonoBehaviour
{
    public AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioManager.PlaySFX(audioManager.flickeringLights);
    }
}
