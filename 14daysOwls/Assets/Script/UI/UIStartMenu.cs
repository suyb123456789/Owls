using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIStartMenu : UI
{
    public void gameStart()
    {
        GameManager.instance.sceneChange("SampleScene");
    }
    public void gameSetting()
    {
        Debug.Log("settingopen");
    }
    public void gameQuit()
    {
        Debug.Log("quitgame");
        Application.Quit();
    }
}
