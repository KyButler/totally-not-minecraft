using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioriteItemFactory : ItemFactory
{
  private string _itemName = "Diorite";
  private Sprite _icon;

  public DioriteItemFactory(){
    this._icon = Resources.Load<Sprite>("Images/Ores/" + this._itemName);
  }

  public DioriteItemFactory(string itemname) {
    this._itemName = itemname;
    this._icon = Resources.Load<Sprite>("Images/Ores/" + itemname);
  }

  public override Item GetItem()
  {
    return new DioriteItem(_itemName);
  }
}
