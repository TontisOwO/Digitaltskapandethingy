using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puzzle1Script : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public Rigidbody2D rigidbody2;
    public GameObject thisObject;
    public FirstPuzzle firstPuzzleScript;
    public AudioManager audioManager;

    public string scene = "Puzzle1";

    public bool doingTwoDifferentThingsWithSameCode;
    public bool doDelete;

    public float spikes;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        if (doingTwoDifferentThingsWithSameCode == true)
        {
            sceneLoader.LoadScene(scene);
        }
        Debug.Log("Click2");
        if (spikes > 1)
        {
            rigidbody2.gravityScale = 1;
            audioManager.PlaySFX(audioManager.nails);
        }
        Debug.Log("Click3");
        if (doDelete == true)
        {
            Debug.Log("Deleting");
            Destroy(thisObject);
            firstPuzzleScript.spikesCount = firstPuzzleScript.spikesCount + 1;
            audioManager.PlaySFX(audioManager.nails);
        }
        Debug.Log("LastClick");
    }
    
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        spikes = spikes + 1;
        
    }
}
