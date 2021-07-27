using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    /*
     * 
     * private AudioManager theAudio; ����??
     * 
     */
    public static bool inventoryActivated = false;

    private InventorySlot[] slots;

    private List<ItemData> inventoryItemList;

   // public TextMeshProUGUI DescriptionText;

    public GameObject go_SlotsParent; // slot �θ�ü

    public GameObject go; // �κ��丮 Ȱ��ȭ ��Ȱ��ȭ

    

    void Start ()
    {
        inventoryItemList = new List<ItemData>();
        slots = go_SlotsParent.GetComponentsInChildren<InventorySlot>();
    }

    void Update()
    {
        TryOpenInventory();
    }

    private void TryOpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryActivated = !inventoryActivated;

            if (inventoryActivated)
                OpenInventory();
            else
                CloseInventory();
        }
    }

    private void OpenInventory()
    {
        go.SetActive(true);
    }

    private void CloseInventory()
    {
        go.SetActive(false);
    }

    public void AcquireItem(ItemData item, int count = 1)
    {
        if(ItemType.KEYITEM != item.type)
        {
            for(int i=0; i<slots.Length; i++)
            {
                if(slots[i].item != null && slots[i].item.itemname == item.itemname)
                {
                    slots[i].SetItemCount(count);
                    return;
                }
            }
        }

        for(int i=0; i<slots.Length; i++)
        {
            if(slots[i].item == null)
            {
                slots[i].AddItem(item, count);
                return;
            }
        }
    }

    
}
