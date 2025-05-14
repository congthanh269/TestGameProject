using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    protected override string GetPrefabName()
    {
        string prefabname = string.Empty;
        List<string> listName = GameManager.Instance.skinData.listNameAtlas;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                prefabname = listName[0];
                break;
            case eNormalType.TYPE_TWO:
                prefabname = listName[1];
                break;
            case eNormalType.TYPE_THREE:
                prefabname = listName[2];
                break;
            case eNormalType.TYPE_FOUR:
                prefabname = listName[3];
                break;
            case eNormalType.TYPE_FIVE:
                prefabname = listName[4];
                break;
            case eNormalType.TYPE_SIX:
                prefabname = listName[5];
                break;
            case eNormalType.TYPE_SEVEN:
                prefabname = listName[6];
                break;
        }

        return prefabname;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}
