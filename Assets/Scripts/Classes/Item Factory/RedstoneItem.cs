using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteProduct
class RedstoneItem : Item
{
    private readonly string _itemName = "Redstone";
    private readonly Sprite _icon;
    private readonly int _price = 11;

    public RedstoneItem()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public RedstoneItem(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override string ItemName
    {
        get { return _itemName; }
    }

    public override Sprite Icon
    {
        get { return _icon; }
    }

    public override int Price
    {
        get{ return _price; }
    }
}
