using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool[] clear_stage = {true,false,false,false};
    public int[] upgrade_step = { 1, 1, 1, 1 };
    private void Awake()
    {
        instance = this;
    }
    public void sceneChange(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
    /*public void OnApplicationPause(bool pause)    // ������ ������ ��׶���� �������� ������ �Ͻ������ϴ� �ڵ�. �����Ϳ����� �׳� ���ڸ��� ����Ǽ� �ּ�ó��.
    {
        gamePause();
    }*/

}
