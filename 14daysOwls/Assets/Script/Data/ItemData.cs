using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    ATKUP,
    MAXHPUP,
    MAXMPUP,
    SPEEDUP,
    RECOVERY,
    MATERIAL,
    KEYITEM
}

[CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable Object/ItemData")]
public class ItemData : ScriptableObject
{
    public int itemid;
    public string itemname;
    public int amount;
    public ItemType type;
    public Sprite sprite;
    public ItemData(int itemid, string name, int amount, ItemType type, Sprite sprite)
    {
        this.itemid = itemid;
        this.name = name;
        this.amount = amount;
        this.type = type;
        this.sprite = sprite;
    }
}
