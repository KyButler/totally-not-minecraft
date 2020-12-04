using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmeraldItemFactory : ItemFactory
{
    private string _itemName = "Emerald";
    private Sprite _icon;

    public EmeraldItemFactory()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public EmeraldItemFactory(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override Item GetItem()
    {
        return new EmeraldItem(_itemName);
    }
}
