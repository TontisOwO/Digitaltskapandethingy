using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class GlassMovement : MonoBehaviour
{
    public AudioManager audioManager;
    public Vector3 mousePos;
    public GameObject left;
    public GameObject right;
    public GameObject top;
    public GameObject bottom;
    public Vector3 releasePos;
    // Start is called before the first frame update
    void Start()
    {
        releasePos = transform.position;
    }
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 1;
        if (transform.position.z != 1)
        {

        }   
        
        if (transform.position.x >= right.transform.position.x)
        {
            transform.position = right.transform.position;
        }
        if (transform.position.x <= left.transform.position.x)
        {
            transform.position = left.transform.position;
        }
        if (transform.position.y >= top.transform.position.y)
        {
            transform.position = top.transform.position;
        }
        if (transform.position.y <= bottom.transform.position.y)
        {
            transform.position = bottom.transform.position;
        }
        if (!Input.GetKey(KeyCode.Mouse0))
        {
            transform.position = releasePos;
        }
        }

    void OnMouseDrag()
    {
        transform.position = mousePos;
        audioManager.PlaySFX(audioManager.glass);
    }
    void OnMouseUp()
    {
        releasePos = mousePos;
    }
}
