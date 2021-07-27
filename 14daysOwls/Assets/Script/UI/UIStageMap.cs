using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIStageMap : UI
{
    private UIStageButton[] stage_buttons;

    private void Start()
    {
        stage_buttons = this.GetComponentsInChildren<UIStageButton>();
        for(int i = 0; i < stage_buttons.Length; i++)
        {
            stage_buttons[i].Stage_Number = i;
        }
    }

}
