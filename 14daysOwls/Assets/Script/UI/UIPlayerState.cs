using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerState : UI
{
    public testcode player;
    private int maxstate = 15;
    private Transform ui_hp;
    private Transform ui_mp;
    private Transform ui_positiveeffect;
    private Transform ui_negativeeffect;

    [SerializeField]
    private Transform[] ui_hp_arr;
    [SerializeField]
    private Transform[] ui_mp_arr;
    [SerializeField]
    private Transform[] ui_pe_arr;
    [SerializeField]
    private Transform[] ui_ne_arr;


    private void Start()
    {
        //player = GameObject.Find("Player").GetComponent<Player>();
        ui_hp = this.transform.GetChild(0);
        ui_mp = this.transform.GetChild(1);
        ui_positiveeffect = this.transform.GetChild(2);
        ui_negativeeffect = this.transform.GetChild(3);
        ui_hp_arr = ui_hp.gameObject.GetComponentsInChildren<Transform>();
        ui_mp_arr = ui_mp.gameObject.GetComponentsInChildren<Transform>();
        ui_pe_arr = ui_positiveeffect.GetComponentsInChildren<Transform>();
        ui_ne_arr = ui_negativeeffect.GetComponentsInChildren<Transform>();
        for(int i = 1; i < ui_hp_arr.Length; i++)
        {
            ui_hp_arr[i].gameObject.SetActive(false);
            ui_mp_arr[i].gameObject.SetActive(false);
            ui_pe_arr[i].gameObject.SetActive(false);
            ui_ne_arr[i].gameObject.SetActive(false);
        }
        updateHp();
    }
    public void updateHp()
    {
        for(int i = 1; i<= player.HP; i++)
        {
            ui_hp_arr[i].gameObject.SetActive(true);
        }
    }
    public void updateMP()
    {
        
    }
    public void updatePositiveEffect()
    {

    }
    public void updateNegativeEffect()
    {

    }
}
