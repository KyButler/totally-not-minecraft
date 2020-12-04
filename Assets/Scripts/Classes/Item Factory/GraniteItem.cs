using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteProduct
class GraniteItem : Item
{
    private readonly string _itemName = "Granite";
    private readonly Sprite _icon;
    private readonly int _price = 1;

    public GraniteItem()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public GraniteItem(string itemname)
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
        get {return _price; }
    }
}
