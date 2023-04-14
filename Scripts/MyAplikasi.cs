using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyAplikasi : MonoBehaviour
{
    // public GameObject pauseMenuScreen;

     public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Close");
    }

    // Update is called once per frame
    public void StartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void CreditButton()
    {
        SceneManager.LoadScene("Credit");
    }

    public void ARButton()
    {
        SceneManager.LoadScene("AR");
    }

    public void CreditBackButton()
    {
        SceneManager.LoadScene("Menu");
    }

    // public void PauseGame()
    // {
    //     Time.timeScale = 0;
    //     pauseMenuScreen.SetActive(true);
    // }

    // public void ResumeGame()
    // {
    //     Time.timeScale = 1;
    //     pauseMenuScreen.SetActive(false);
    // }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
