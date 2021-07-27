using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
public class UIPopUp : MonoBehaviour
{
    public delegate void Callback();
    private Callback callyes;
    private Callback callno;
    public enum select
    {
        YES,
        NO
    }

    private TextMesh massage;

    private GameObject yesbutton;
    private GameObject nobutton;

    public void openUI(string message,Callback yesbutooncall,Callback nobuttoncall)
    {
        massage.text = message;
        

    }
    public void setCallback(Callback call)
    {
        
    }

}
