using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemClick : MonoBehaviour
{
    public Item Item;
    public MainItem mainItem;

    private void click()
    {
        InventoryManager.Instance.Add(Item);
    }

    private void OnMouseDown()
    {
        click();
    }
}

