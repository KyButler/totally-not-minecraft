using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronItemFactory : ItemFactory
{
    private string _itemName = "Iron";
    private Sprite _icon;

    public IronItemFactory()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public IronItemFactory(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override Item GetItem()
    {
        return new IronItem(_itemName);
    }
}
