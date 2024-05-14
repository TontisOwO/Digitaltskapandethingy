using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GlassScript GlassScript;
    public bool GlassInPlace;
    public float whatGlass;
    public bool correctPiece;

    public void Update()
    {
        SelectGlass();
        if (correctPiece == true)
        {
            SelectGlass();
            if(GlassScript.inPlace == true) 
            {
                GlassInPlace = true;
            }
            if (GlassScript.inPlace == false)
            { 
                GlassInPlace = false; 
            }
        }
        else
        {
            if (correctPiece == false)
            {
                GlassInPlace=false;
            }
        }

    }

    private void SelectGlass()
    {
        switch (whatGlass)
        {
            case 0:
                {
                    if (GlassScript.whatGoal == 0)
                    {
                        correctPiece = true;
                    }
                    else
                    {
                        correctPiece = false;
                    }
                    break;
                }

            case 1:
                {
                    if (GlassScript.whatGoal == 1)
                    {
                        correctPiece = true;
                    }
                    else
                    {
                        correctPiece = false;
                    }
                    break;
                }

            case 2:
                {
                    if (GlassScript.whatGoal == 2)
                    {
                        correctPiece = true;
                    }
                    else
                    {
                        correctPiece = false;
                    }
                    break;
                }

            case 3:
                {
                    if (GlassScript.whatGoal == 3)
                    {
                        correctPiece = true;
                    }
                    else
                    {
                        correctPiece = false;
                    }
                    break;
                }

            case 4:
                {
                    if (GlassScript.whatGoal == 4)
                    {
                        correctPiece = true;
                    }
                    else
                    {
                        correctPiece = false;
                    }
                    break;
                }
            case 10:
                {
                    correctPiece = false;
                    break;
                }

        }
    }
}
