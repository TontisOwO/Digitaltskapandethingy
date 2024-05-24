using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleBoxScript : MonoBehaviour
{
    public AudioManager audioManager;
    public SpriteRenderer rend;
    public SavedData data;
    public List<Sprite> sprites;
    public GameObject key;
    public GameObject keySpawn;
    public GameObject numbers;
    public Vector3 size;
    public Vector3 position;
    bool CanSpawn = true;

    void Start()
    {
        
    }
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        if (data.OpenedBox == true)
        {
            rend.sprite = sprites[1];
            size.x = 5.4f;
            size.y = 5.4f;
            transform.localScale = size;
            position.x = -0.2f;
            position.y = 1.2f;
            audioManager.PlaySFX(audioManager.openBox);
            transform.position = position;
            GameObject.Destroy(numbers);
            if (data.BuildingKey == false && CanSpawn == true)
            {
                GameObject.Instantiate(key, keySpawn.transform.position, key.transform.rotation);
                CanSpawn = false;
            }
            else
            {
                return;
            }
        }
    }
}
