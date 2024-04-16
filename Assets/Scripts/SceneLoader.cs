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
    string menu = "Settings";
    bool inSettings = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (inSettings == true)
            {
                return;
            }
            SceneManager.LoadScene(menu);
            inSettings = true;
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        inSettings = false;
    }

    public void AltLoadScene()
    {
        SceneManager.LoadScene(secondaryScene);
        inSettings = false;
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(PlayerData.CurrentFloor);
        inSettings = false;
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
        inSettings = false;
    }
}
