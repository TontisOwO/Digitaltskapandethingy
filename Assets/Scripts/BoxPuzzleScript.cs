using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPuzzleScript : MonoBehaviour
{
    public SavedData mydata;
    public GameObject Key;
    int MinValue = 0;
    int MaxValue = 19;
    public int KeySpawn;
    public float Xvalue = 0;
    public float Yvalue = 0;

    void Start()
    {
        KeySpawn = Random.Range(MinValue, MaxValue); 
    }

    void Update()
    {
        KeyLocation();
        Vector3 KeyPos = Key.GetComponent<Rigidbody2D>().position;
        KeyPos.x = Xvalue;
        KeyPos.y = Yvalue;
        Key.transform.position = KeyPos;
       
    }

    private void KeyLocation()
    {
        switch (KeySpawn)
        {
            case 0:
                {
                    Xvalue = -8;
                    Yvalue = -3;
                    break;
                }

            case 1:
                {
                    Xvalue = -8;
                    Yvalue = -2;
                    break;
                }

            case 2:
                {
                    Xvalue = -6;
                    Yvalue = -2;
                    break;
                }

            case 3:
                {
                    Xvalue = -6;
                    Yvalue = 0;
                    break;
                }

            case 4:
                {
                    Xvalue = -6;
                    Yvalue = -3;
                    break;
                }

            case 5:
                {
                    Xvalue = 4;
                    Yvalue = -1;
                    break;
                }

            case 6:
                {
                    Xvalue = 5;
                    Yvalue = 0;
                    break;
                }

            case 7:
                {
                    Xvalue = 6;
                    Yvalue = 0;
                    break;
                }

            case 8:
                {
                    Xvalue = 6;
                    Yvalue = 2;
                    break;
                }

            case 9:
                {
                    Xvalue = 6;
                    Yvalue = -1;
                    break;
                }

            case 10:
                {
                    Xvalue = -3;
                    Yvalue = 0;
                    break;
                }

            case 11:
                {
                    Xvalue = -3;
                    Yvalue = 1;
                    break;
                }

            case 12:
                {
                    Xvalue = -1;
                    Yvalue = 1;
                    break;
                }

            case 13:
                {
                    Xvalue = -2;
                    Yvalue = 3;
                    break;
                }

            case 14:
                {
                    Xvalue = -1;
                    Yvalue = 0;
                    break;
                }

            case 15:
                {
                    Xvalue = 0;
                    Yvalue = -4;
                    break;
                }

            case 16:
                {
                    Xvalue = 0;
                    Yvalue = -2;
                    break;
                }

            case 17:
                {
                    Xvalue = 2;
                    Yvalue = -2;
                    break;
                }

            case 18:
                {
                    Xvalue = 1;
                    Yvalue = 0;
                    break;
                }

            case 19:
                {
                    Xvalue = 2;
                    Yvalue = -3;
                    break;
                }
        }
    }
}
