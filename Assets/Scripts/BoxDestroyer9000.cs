using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroyer9000 : MonoBehaviour
{
    public GameObject victim;
    public bool KILL = false;
    int boxObliterationStage = 3;
    public float coolDown;
    float lastAnnihilation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if (KILL == true)
        {
            boxObliterationStage -= 1;
            KILL = false;
            if (boxObliterationStage <= 0)
            {
                GameObject.Destroy(victim);
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
