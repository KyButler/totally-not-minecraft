using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldItemFactory : ItemFactory
{
    private string _itemName = "Gold";
    private Sprite _icon;

    public GoldItemFactory()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public GoldItemFactory(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override Item GetItem()
    {
        return new GoldItem(_itemName);
    }
}
