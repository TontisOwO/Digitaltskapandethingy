using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxPuzzleScript : MonoBehaviour
{
    public SavedData mydata;
    public GameObject Key;
    int MinValue = 0;
    int MaxValue = 19;
    public int KeySpawn;
    public float Xvalue = 0;
    public float Yvalue = 0;
    public int CurrentFloor;

    //Boxdestroyer9000
    public GameObject victim;
    public bool KILL = false;
    int boxObliterationStage = 3;
    public float coolDown;
    float lastAnnihilation;

    void Start()
    {
        KeySpawn = Random.Range(MinValue, MaxValue); 
        CurrentFloor = mydata.CurrentFloor;
    }

    public void Update()
    {
        KeyLocation();
        Vector3 KeyPos = Key.GetComponent<Rigidbody2D>().position;
        KeyPos.x = Xvalue;
        KeyPos.y = Yvalue;
        Key.transform.position = KeyPos;

        if (mydata.KeyItem == true)
        {
            SceneManager.LoadScene(CurrentFloor);
        }

        if (KILL == true)
        {
            boxObliterationStage -= 1;
            KILL = false;
            if (boxObliterationStage <= 0)
            {
                GameObject.Destroy(gameObject);
            }
        }
    }



    private void KeyLocation()
    {
        switch (KeySpawn)
        {
            case 0:
                {
                    Xvalue = 480;
                    Yvalue = 95;
                    break;
                }

            case 1:
                {
                    Xvalue = 65;
                    Yvalue = 95;
                    break;
                }

            case 2:
                {
                    Xvalue = 95;
                    Yvalue = 140;
                    break;
                }

            case 3:
                {
                    Xvalue = 285;
                    Yvalue = 40;
                    break;
                }

            case 4:
                {
                    Xvalue = 505;
                    Yvalue = 140;
                    break;
                }

            case 5:
                {
                    Xvalue = 285;
                    Yvalue = 85;
                    break;
                }

            case 6:
                {
                    Xvalue = 215;
                    Yvalue = 260;
                    break;
                }

            case 7:
                {
                    Xvalue = 310;
                    Yvalue = 130;
                    break;
                }

            case 8:
                {
                    Xvalue = 530;
                    Yvalue = 100;
                    break;
                }

            case 9:
                {
                    Xvalue = 65;
                    Yvalue = 50;
                    break;
                }

            case 10:
                {
                    Xvalue = 185;
                    Yvalue = 220;
                    break;
                }

            case 11:
                {
                    Xvalue = 475;
                    Yvalue = 50;
                    break;
                }

            case 12:
                {
                    Xvalue = 235;
                    Yvalue = 225;
                    break;
                }

            case 13:
                {
                    Xvalue = 235;
                    Yvalue = 180;
                    break;
                }

            case 14:
                {
                    Xvalue = 120;
                    Yvalue = 55;
                    break;
                }

            case 15:
                {
                    Xvalue = 115;
                    Yvalue = 100;
                    break;
                }

            case 16:
                {
                    Xvalue = 335;
                    Yvalue = 85;
                    break;
                }

            case 17:
                {
                    Xvalue = 540;
                    Yvalue = 50;
                    break;
                }

            case 18:
                {
                    Xvalue = 340;
                    Yvalue = 40;
                    break;
                }

            case 19:
                {
                    Xvalue = 185;
                    Yvalue = 175;
                    break;
                }
        }
    }

    public void Annihilate()
    {
        if (KILL == false)
        {
            if (Time.time - lastAnnihilation < coolDown)
            {
                return;
            }
            lastAnnihilation = Time.time;
            KILL = true;
        }
    }
}
