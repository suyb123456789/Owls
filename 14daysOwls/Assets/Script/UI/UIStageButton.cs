using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStageButton : UI
{
    private int stage_number;
    private Transform unable;
    public int Stage_Number
    {
        get { return stage_number; }
        set { stage_number = value; }
    }
    private void Awake()
    {
        unable = this.transform.GetChild(1);
        
    }
    private void OnEnable()
    {
        if (GameManager.instance.clear_stage[stage_number])
        {
            unable.gameObject.SetActive(false);
        }
        else
        {
            unable.gameObject.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("level" + stage_number.ToString());
        //GameManager.instance.sceneChange("level" + stage_number.ToString());
    }
}
