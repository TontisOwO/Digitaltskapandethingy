using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroyer9000 : MonoBehaviour
{
    public GameObject victim;
    public bool KILL = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if (KILL == true)
        {
            GameObject.Destroy(victim);
        }
    }

    // Update is called once per frame
    public void Annihilate()
    {
        if (KILL == false)
        {
            KILL = true;
        }
    }
}
