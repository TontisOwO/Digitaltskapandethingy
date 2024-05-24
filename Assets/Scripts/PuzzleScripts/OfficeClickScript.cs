using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeClickScript : MonoBehaviour
{
    public AudioManager audioManager;
    public Vector3 mousePos;
    public GameObject Selecter;
    public OfficeZoomScript zoomScript;
    public SceneLoader sceneLoader;
    public int whatObject;
    public bool Box = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonUp(0))
        {
            zoomScript.sprite = 0;

        }
        if (zoomScript.sprite == 1)
        {
            audioManager.PlaySFX(audioManager.paper);
        }
        if (zoomScript.sprite == 2)
        {
            audioManager.PlaySFX(audioManager.paperBin);
        }
        if (zoomScript.sprite == 3)
        {
            audioManager.PlaySFX(audioManager.clock);
        }
        if (zoomScript.sprite == 4)
        {
            audioManager.PlaySFX(audioManager.paper);
        }
    }

    void OnMouseOver()
    {
            if (Input.GetMouseButtonDown(0))
            {
            if (Box == true)
            {
                sceneLoader.LoadScene("PuzzleBox");
                return;
            }
                zoomScript.sprite = whatObject;
            }       
    }
}
