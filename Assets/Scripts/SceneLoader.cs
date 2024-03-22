using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SavedData PlayerData = null;
    public string floor1 = "Totorial";
    public string sceneName;
    public string secondaryScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void AltLoadScene()
    {
        SceneManager.LoadScene(secondaryScene);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(PlayerData.CurrentFloor);
    }

    public void EraseData()
    {
        PlayerData.AxeItem = false;
        PlayerData.CrubrItem = false;
        PlayerData.MatchItem = false;
        PlayerData.KeyItem = false;
        PlayerData.SampleItem = false;
        PlayerData.CurrentFloor = 1;
        SceneManager.LoadScene(floor1);
    }
}
