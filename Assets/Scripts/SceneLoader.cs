using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SavedData PlayerData = null;
    public string floor1 = "Totorial";
    string menu = "Settings";

    public Movement Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //open settings
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (PlayerData.inMenu == true )
            {
                SceneManager.LoadScene(PlayerData.CurrentFloor);
                PlayerData.inMenu = false;
            }
            if (PlayerData.inMenu == false )
            {
                SceneManager.LoadScene(menu);
                PlayerData.inMenu = true;
            }
        }
    }

    //first scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //second scene
    public void AltLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //load game in main menu
    public void ContinueGame()
    {
        SceneManager.LoadScene(PlayerData.CurrentFloor);
    }

    public void EnterPuzzleScene(string sceneName)
    {
        PlayerData.CharPos = Player.wantedPos;
        SceneManager.LoadScene(sceneName);
    }
    public void ExitPuzzleScene(string sceneName)
    {
        PlayerData.exitedPuzzleScene = true;
        SceneManager.LoadScene(sceneName);

    }

    //new game in main menu
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
