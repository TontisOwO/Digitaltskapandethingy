using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBoxButton : MonoBehaviour
{
    public PuzzleBoxSelect nr1;
    public PuzzleBoxSelect nr2;
    public PuzzleBoxSelect nr3;
    public PuzzleBoxSelect nr4;
    public SpriteRenderer mySpriteRenderer;
    public Sprite sprite;
    public SpriteRenderer box;
    public Sprite openbox;
    public SceneLoader sceneLoader;
    public string scene;
    public SavedData savedData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(nr1.hovering || nr2.hovering || nr3.hovering || nr4.hovering))
        {
            mySpriteRenderer.sprite = sprite;
        }
        if (nr1.NumberPhase == nr1.NumberCorrect &&
            nr2.NumberPhase == nr2.NumberCorrect &&
            nr3.NumberPhase == nr3.NumberCorrect &&
            nr4.NumberPhase == nr4.NumberCorrect) 
        {
            savedData.OpenedBox = true;
            sceneLoader.LoadScene(scene);
        }
    }
}