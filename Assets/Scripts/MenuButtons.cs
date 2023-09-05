using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuButtons : MonoBehaviour
{

    [SerializeField] GameObject mainMenuCanvas;
    [SerializeField] GameObject settingsCanvas;

    public void StartButton()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitButton()
    {
        Debug.Log("Quit");
        //Application.Quit(); 
    }

    public void SettingsBackButton()
    {
        mainMenuCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
    }

    public void SettingsButton()
    {
        settingsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

}
