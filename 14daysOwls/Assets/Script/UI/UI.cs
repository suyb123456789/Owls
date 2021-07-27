using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
   public virtual void openUI()
    {
        this.gameObject.SetActive(true);
        UIManager.instance.ui_stack.Push(this.gameObject);
    }
    public virtual void CloseUI()
    {
        this.gameObject.SetActive(false);
        UIManager.instance.ui_stack.Pop();
    }
}
