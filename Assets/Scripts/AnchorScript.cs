using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorScript : MonoBehaviour
{
    public Vector3 Anchor;
    // Start is called before the first frame update
    void Start()
    {
        Anchor = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Anchor;
    }
}
