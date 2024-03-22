using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SavedData playerData = null;
    public string floor1 = "SampleScene";
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

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void AltLoadScene()
    {
        SceneManager.LoadScene(SecondaryScene);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(playerData.CurrentFloor);
    }

    public void EraseData()
    {
        playerData.AxeItem = false;
        playerData.CrubrItem = false;
        playerData.MatchItem = false;
        playerData.KeyItem = false;
        playerData.SampleItem = false;
        playerData.CurrentFloor = 1;
        SceneManager.LoadScene(floor1);
    }
}
