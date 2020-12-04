using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraniteItemFactory : ItemFactory
{
    private string _itemName = "Granite";
    private Sprite _icon;

    public GraniteItemFactory()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public GraniteItemFactory(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override Item GetItem()
    {
        return new GraniteItem(_itemName);
    }
}
