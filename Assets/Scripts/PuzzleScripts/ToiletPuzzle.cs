using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToiletPuzzle : MonoBehaviour
{
    public AudioManager AudioManager;
    public GoalScript Piece1;
    public GoalScript Piece2;
    public GoalScript Piece3;
    public GoalScript Piece4;
    public GoalScript Piece5;
    public GameObject Key;
    public GameObject Canvas;
    public int count;
    public int maxCount = 5;
    public int minCount = 0;
    public bool Test = false;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= minCount)
        {
            count = minCount;
        }
        if (count >= maxCount)
        {
            count = maxCount;
        }
        //Check if pieces are in place
        if (Piece1.GlassInPlace == true)
        {
            count += 1;
            Piece1.whatGlass = 10;
        }
        if (Piece2.GlassInPlace == true)
        {
            count += 1;
            Piece2.whatGlass = 10;
        }
        if (Piece3.GlassInPlace == true)
        {
            count += 1;
            Piece3.whatGlass = 10;
        }
        if (Piece4.GlassInPlace == true)
        {
            count += 1;
            Piece4.whatGlass = 10;
        }
        if (Piece5.GlassInPlace == true)
        {
            count += 1;
            Piece5.whatGlass = 10;
        }

        if (count == 5)
        {
            GameObject.Instantiate(Key, this.transform.position, Key.transform.rotation, Canvas.transform);
            count = 0;
            AudioManager.PlaySFX(AudioManager.keyDrop);
            Key.transform.SetParent(Canvas.transform, false);
        }
    }
}
