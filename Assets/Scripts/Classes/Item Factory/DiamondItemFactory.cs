using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondItemFactory : ItemFactory
{
  private string _itemName = "Diamond";
  private Sprite _icon;  

  public DiamondItemFactory(){
    this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
  }

  public DiamondItemFactory(string itemname) {
    this._itemName = itemname;
    this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
  }

  public override Item GetItem()
  {
    return new DiamondItem(_itemName);
  }
}