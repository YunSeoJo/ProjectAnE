using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Light,
    Table,
    Chair,
    Storage,
    Props,
    Etc
}

[System.Serializable]
public class Item
{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;

    public bool Use()
    {
        bool isUsed = false;
        isUsed = true;


        return isUsed;
    }
}
