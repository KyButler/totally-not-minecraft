using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalItemFactory : ItemFactory
{
  private string _itemName = "Coal";
  private Sprite _icon;

  public CoalItemFactory(){
    this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
  }

  public CoalItemFactory(string itemname) {
    this._itemName = itemname;
    this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
  }

  public override Item GetItem()
  {
    return new CoalItem(_itemName);
  }
}