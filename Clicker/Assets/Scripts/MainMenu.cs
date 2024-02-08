using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void onClickEnterTheGame()
    {
        SceneManager.LoadScene(0);

    }

    public GameObject mainMenu;
    public GameObject settings;

    public void onClickSetting()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void onClickSettingEXT()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }

    public void onClickMainMenu()
        {
        SceneManager.LoadScene(1);

        }

    public void onClickExitTheGame()
    {
        Application.Quit();
    }

    
}
