using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

//unity inventory system 參考資料
//https://blog.csdn.net/xinzhilinger/article/details/113696369?ops_request_misc=&request_id=&biz_id=102&utm_term=unity%20%E8%83%8C%E5%8C%85%E7%B3%BB%E7%B5%B1&utm_medium=distribute.pc_search_result.none-task-blog-2~all~sobaiduweb~default-9-113696369.142^v68^pc_new_rank,201^v4^add_ask,213^v2^t3_control2&spm=1018.2226.3001.4187

public class InventoryManager : MonoBehaviour
{
    public Item Item;
    public static InventoryManager Instance;
    public MainItem mainItem;
    public Slot slotPrefab;
    public Transform ItemContent;
    public GameObject InventoryItem;
    int count;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        mainItem.itemList.Clear();
        Instance = this;
        Item.itemAmount = 0;
    }

    public void Add(Item item)
    {
        count = 0;
        mainItem.itemList.Add(item);

        if(!mainItem.itemList.Contains(Item))
        {
            mainItem.itemList.Add(Item);
        }
        else 
        {
            Item.itemAmount++;
            updateItemToUI();
        }
    }
    
    public void Remove(Item item)
    {
        mainItem.itemList.Remove(item);
    }


    private void OnEnable()
    {
        updateItemToUI();
    }
    
    public static void createObject(Item item)
    {            
        Slot slot = Instantiate(Instance.slotPrefab, Instance.ItemContent.transform);
        slot.BK.sprite = item.BKimg;
        slot.rawImage.texture = item.image;
        slot.name.text = item.itemName.ToString();
        slot.price.text = item.itemPrice.ToString();
        slot.priceNum.text = item.itemPriceNum.ToString();
        slot.amount.text = item.itemAmount.ToString();
    }

     public static void updateItemToUI()
    {
        for (int i = 0; i < Instance.ItemContent.childCount; i++)
        {   

            Debug.Log(Instance.ItemContent.GetChild(i));
            Destroy(Instance.ItemContent.GetChild(i).gameObject);
        }


        //create Object
        for (int i = 0; i < Instance.mainItem.itemList.Count; i++)
        {
            if(Instance.Item.itemAmount > 1)
            {
                createObject(Instance.mainItem.itemList[0]);
                break;
            }
            
        }

        
    }

    


}

