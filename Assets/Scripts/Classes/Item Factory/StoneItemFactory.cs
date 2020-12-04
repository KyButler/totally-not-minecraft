using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneItemFactory : ItemFactory
{
  private string _itemName = "Stone";
  private Sprite _icon;

  public StoneItemFactory(){
    this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
  }

  public StoneItemFactory(string itemname) {
    this._itemName = itemname;
    this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
  }

  public override Item GetItem()
  {
    return new StoneItem(_itemName);
  }
}