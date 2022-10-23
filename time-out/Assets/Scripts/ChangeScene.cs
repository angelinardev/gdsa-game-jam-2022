using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        //SceneManager.UnloadSceneAsync(sceneName:"SampleScene");
        SceneManager.LoadScene (sceneName:"SampleScene");
       
    }
    public void GameOver()
    {
         SceneManager.LoadScene (sceneName:"GameOverMenu");
    }
    public void WinScreen()
    {
        SceneManager.LoadScene (sceneName:"WinMenu");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene (sceneName:"StartMenu");
    }
}
