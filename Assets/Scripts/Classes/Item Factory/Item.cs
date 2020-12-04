using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Product

[System.Serializable]
public abstract class Item{
    public abstract string ItemName { get; }
    public abstract Sprite Icon { get; }
    public abstract int Price { get; }
}

