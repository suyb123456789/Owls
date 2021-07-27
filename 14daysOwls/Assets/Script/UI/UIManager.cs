using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public UIPopUp UI_PopUp;   // popup script
    public UIPause UI_Pause;   // pause script
    public UIStageMap UI_Stage;
    public UIPlayerState UI_PlayerState;
    public Stack<GameObject> ui_stack;
    


    public void Awake()
    {
        instance = this;    // singleton ¸¸µê
        UI_PopUp = this.GetComponentInChildren<UIPopUp>();
        UI_Pause = this.GetComponentInChildren<UIPause>();
        UI_Stage = this.GetComponentInChildren<UIStageMap>();
        UI_PlayerState = this.GetComponentInChildren<UIPlayerState>();
    }


}
