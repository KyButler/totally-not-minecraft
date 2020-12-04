using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedstoneItemFactory : ItemFactory
{
    private string _itemName = "Redstone";
    private Sprite _icon;

    public RedstoneItemFactory()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public RedstoneItemFactory(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override Item GetItem()
    {
        return new RedstoneItem(_itemName);
    }
}
