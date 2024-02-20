using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SavedData playerData = null;
    public string SceneName = "SampleScene";
    public string SecondaryScene = "Adonai's Work Place";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void AltLoadScene()
    {
        SceneManager.LoadScene(SecondaryScene);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(playerData.CurrentFloor);
    }
}
