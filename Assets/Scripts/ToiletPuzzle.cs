using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToiletPuzzle : MonoBehaviour
{
    public GoalScript Piece1;
    public GoalScript Piece2;
    public GoalScript Piece3;
    public GoalScript Piece4;
    public GoalScript Piece5;
    public GameObject Key;
    public float count;
    float currentCount;
    public float maxCount = 5;
    public float minCount = 0;
    public bool Test = false;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 0)
        {
            count = 0;
        }
        if (count > 5)
        {
            count = 5;
        }
        //Check if pieces are in place
        if (Piece1.GlassInPlace == true)
        {
            count += 1;
            return;
        }
        if (Piece2.GlassInPlace == true)
        {
            count += 1;
            return;
        }
        if (Piece3.GlassInPlace == true)
        {
            count += 1;
            return;
        }
        if (Piece4.GlassInPlace == true)
        {
            count += 1;
            return;
        }
        if (Piece5.GlassInPlace == true)
        {
            count += 1;
            return;
        }

        if (count >= 5)
        {
            GameObject.Instantiate(Key, this.transform.position, Key.transform.rotation);
        }
    }
}
