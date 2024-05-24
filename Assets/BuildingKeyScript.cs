using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BuildingKeyScript : MonoBehaviour
{
    public Vector3 mousePos;
    public SavedData myData;
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
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myData.BuildingKey = true;
            GameObject.Destroy(gameObject);
            audioManager.PlaySFX(audioManager.keys);
        }
    }
}
