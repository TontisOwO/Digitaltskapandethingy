using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layerfuckery : MonoBehaviour
{
    public NPCScript npc;
    public Movement player;
    public SpriteRenderer mySpriteRenderer;
    int layerCurrent;
    int layerOriginal;
    void Start()
    {
        layerOriginal = mySpriteRenderer.sortingOrder;
        layerCurrent = layerOriginal;
    }

    void Update()
    {
        layerCurrent = layerOriginal;
        if (player.wantedPos.y - 0.3 > npc.currentPos.y)
        {
            layerCurrent = layerOriginal - 20;
        }
        mySpriteRenderer.sortingOrder = layerCurrent;
    }
}
