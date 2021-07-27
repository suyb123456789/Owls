using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWitch : UI
{
    private Transform icons;
    private Transform needs;
    private Transform[] icon_arr;
    private Transform[] need_arr;

    private void Start()
    {
        icons = this.transform.GetChild(0);
        needs = this.transform.GetChild(1);

        icon_arr = icons.GetComponentsInChildren<Transform>();
        need_arr = needs.GetComponentsInChildren<Transform>();


    }
    private void OnEnable()
    {
        
    }
}
