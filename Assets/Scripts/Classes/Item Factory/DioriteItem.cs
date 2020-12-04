using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteProduct
class DioriteItem : Item
{
    private readonly string _itemName = "Diorite";
    private readonly Sprite _icon;
    private readonly int _price = 1;

    public DioriteItem()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public DioriteItem(string itemname)
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
