using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public void onClickEnter()
    {
        SceneManager.LoadScene("game"); // дописать

    }

    public GameObject win1;
    public GameObject win2;

    public void onClickSetting()
    {
        win1.SetActive(false);
        win2.SetActive(true);
    }

    public void onClickSettingEXT()
    {
        win1.SetActive(true);
        win2.SetActive(false);
    }

    public void onClickExit()
    {
        Application.Quit();
    }

    
}
