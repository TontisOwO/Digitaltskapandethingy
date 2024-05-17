using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxIfWanted : MonoBehaviour
{
    public Movement Movement;
    public Vector3 paralaxedPos;
    // Update is called once per frame
    void Update()
    {
        //paralax by how far away it is
        paralaxedPos.x = Movement.wantedPos.x / transform.position.z;
        paralaxedPos.y = 0;
        paralaxedPos.z = transform.position.z;
        transform.position = paralaxedPos;
    }
}
