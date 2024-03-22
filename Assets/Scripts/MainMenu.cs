using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
      SceneManager.LoadSceneAsync("MiniGame"); 
   }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void GoToCredits()
    {
        SceneManager.LoadSceneAsync("Credits");
    }

    public void GoToInstructions()
    {
        SceneManager.LoadSceneAsync("Instructions");
    }

    public void GoToGameOver()
    {
        SceneManager.LoadSceneAsync("GameOver");
    } 

    public void GoToWin()
    {
        SceneManager.LoadSceneAsync("Win");
    }

}
