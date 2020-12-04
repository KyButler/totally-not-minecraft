using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndesiteItemFactory : ItemFactory
{
    private string _itemName = "Andesite";
    private Sprite _icon;

    public AndesiteItemFactory()
    {
        this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
    }

    public AndesiteItemFactory(string itemname)
    {
        this._itemName = itemname;
        this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
    }

    public override Item GetItem()
    {
        return new AndesiteItem(_itemName);
    }
}
