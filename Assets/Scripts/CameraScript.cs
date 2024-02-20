using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Vector3 CameraPos;
    void Update()
    {
        CameraPos = transform.position;
        CameraPos.z = -1;
    }
}
