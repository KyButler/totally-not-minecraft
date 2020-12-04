using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapisItemFactory : ItemFactory
{
    private string _itemName = "Lapis";
    private Sprite _icon;

    public LapisItemFactory()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public LapisItemFactory(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override Item GetItem()
    {
        return new LapisItem(_itemName);
    }
}
