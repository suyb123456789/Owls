using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public ItemData item;
    public Image icon;
    public int itemCount;
    public TextMeshProUGUI itemCount_Text;
    public GameObject go_Count;

    public void Additem(ItemData item, int count = 1)
    {
        this.item = item;
        icon.sprite = item.sprite;
        itemCount = count;

        if(item.type == ItemType.KEYITEM)
        {
            itemCount_Text.text = "0";
            go_Count.SetActive(false);
        }
        else
        {
            go_Count.SetActive(true);
            itemCount_Text.text = itemCount.ToString();
        }
    }

    public void SetItemCount(int count)
    {
        itemCount += count;
        itemCount_Text.text = itemCount.ToString();

        if (itemCount <= 0)
            RemoveItem();
    }

    public void RemoveItem()
    {
        item = null;
        icon.sprite = null;
        itemCount = 0;
        itemCount_Text.text = "0";
        go_Count.SetActive(false);
    }
}
