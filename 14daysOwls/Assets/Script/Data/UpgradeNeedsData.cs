using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UpgradeType
{
    Atk,
    HP,
    MP,
    Speed
}
public class UpgradeNeedsData : ScriptableObject
{
    public UpgradeType Type;
    public int Upgrade_Step;
    public ItemData[] Need_Items;
    public int[] Need_Items_count;

    public UpgradeNeedsData(UpgradeType type, int step, ItemData[] items, int[] itemcount)
    {
        Type = type;
        Upgrade_Step = step;
        Need_Items = items;
        Need_Items_count = itemcount;
    }
}
