using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DataBase", menuName = "Scriptable Object/DataBase")]
public class DataBase : ScriptableObject
{
    public List<ItemData> Item_Data_List = new List<ItemData>();
    public List<UpgradeNeedsData> Upgrade_Data_List = new List<UpgradeNeedsData>();
    
    
    public void loadDB(){
        Item_Data_List.Add(new ItemData(0, "공격력증가1단계", 1, ItemType.ATKUP, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));
        Item_Data_List.Add(new ItemData(0, "최대체력증가1단계", 1, ItemType.MAXHPUP, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));
        Item_Data_List.Add(new ItemData(0, "최대기력증가1단계", 1, ItemType.MAXMPUP, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));
        Item_Data_List.Add(new ItemData(0, "속도증가1단계", 1, ItemType.SPEEDUP, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));
        Item_Data_List.Add(new ItemData(0, "체력회복1단계", 1, ItemType.RECOVERY, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));
        Item_Data_List.Add(new ItemData(0, "재료1", 0, ItemType.MATERIAL, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));
        Item_Data_List.Add(new ItemData(0, "재료2", 0, ItemType.MATERIAL, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));
        Item_Data_List.Add(new ItemData(0, "재료3", 0, ItemType.MATERIAL, Resources.Load<Sprite>("Assets/Resources/ItemIcon/0")));

        ItemData[] need = { Item_Data_List[6], Item_Data_List[7], Item_Data_List[8] };
        int [] needs = { 1,1,1};
        Upgrade_Data_List.Add(new UpgradeNeedsData(UpgradeType.Atk, 1, need, needs));
        Upgrade_Data_List.Add(new UpgradeNeedsData(UpgradeType.HP, 1, need, needs));
        Upgrade_Data_List.Add(new UpgradeNeedsData(UpgradeType.MP, 1, need, needs));
        Upgrade_Data_List.Add(new UpgradeNeedsData(UpgradeType.Speed, 1, need, needs));


    }
}
