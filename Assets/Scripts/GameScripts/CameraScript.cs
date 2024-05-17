using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour   
{
    public Vector3 cameraPos;
    public float minPos = -5;
    public float maxPos = 5;
    void Update()
    {
        cameraPos.y = 0;
        cameraPos.z = -10;
        cameraPos.x = Mathf.Clamp(cameraPos.x, minPos, maxPos);
        transform.position = cameraPos;
    }
}
