using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Item", menuName="Item/Create New Item")]
public class Item : ScriptableObject
{
    public Texture image;
    public Sprite BKimg;
    public string itemName;
    public string itemPrice;
    public string itemPriceNum;
    public int itemAmount;
}

