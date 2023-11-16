using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ItemInfoSO : ScriptableObject
{
    [SerializeField] private ItemInfo[] itemInfos;

    public Sprite GetSpriteItem(NormalItem.eNormalType eNormalType)
    {
        Sprite sprite = null;
        for (int i = 0; i < itemInfos.Length; i++)
        {
            if (eNormalType == itemInfos[i].normalType)
            {
                sprite = itemInfos[i].sprite;
                break;
            }
        }

        return sprite;
    }
}

[Serializable]
public class ItemInfo
{
    public NormalItem.eNormalType normalType;
    public Sprite sprite;
}