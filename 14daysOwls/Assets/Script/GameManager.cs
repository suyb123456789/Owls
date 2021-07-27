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
    /*public void OnApplicationPause(bool pause)    // 유저가 게임을 백그라운드로 내렸을때 게임을 일시정지하는 코드. 에디터에서는 그냥 켜자마자 실행되서 주석처리.
    {
        gamePause();
    }*/

}
