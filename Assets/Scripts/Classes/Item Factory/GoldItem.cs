using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteProduct
class GoldItem : Item
{
    private readonly string _itemName = "Gold";
    private readonly Sprite _icon;
    private readonly int _price = 6;

    public GoldItem()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public GoldItem(string itemname)
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
