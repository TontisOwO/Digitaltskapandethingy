using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxIfWanted : MonoBehaviour
{
    public CameraScript CameraScript;
    public Vector3 paralaxedPos;
    // Update is called once per frame
    void Update()
    {
        //paralax by how far away it is
        paralaxedPos.x = CameraScript.cameraPos.x / transform.position.z;
        paralaxedPos.y = 0;
        paralaxedPos.z = transform.position.z;
        transform.position = paralaxedPos;
    }
}
