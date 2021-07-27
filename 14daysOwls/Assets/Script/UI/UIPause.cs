using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPause : UI
{
    public override void openUI()
    {
        base.openUI();
        Time.timeScale = 0;
    }
    public void reStart()
    {
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    } 
    public void openSetting()
    {
        Debug.Log("Setting");
    }
    public void quitGame()
    {
        // popup����� ���� ������ ����� ����
    }
}
