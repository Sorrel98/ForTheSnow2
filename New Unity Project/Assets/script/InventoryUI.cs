using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    Inventory inven;

    public GameObject inventoryPanel;
    bool activeInventory = false;

    public Slot[] slots;
    public Transform slotHolder;
    public ShopSlot[] shopSlots;
    public Transform shopHolder;

    void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        shopSlots = shopHolder.GetComponentsInChildren<ShopSlot>();
        for(int i = 0; i<shopSlots.Length; i++)
        {
            shopSlots[i].Init(this);
            shopSlots[i].slotnum = i;
        }
        inven.onSlotCountChange += SlotChange;
        inven.onChangeItem += RedrawSlotUI;
        RedrawSlotUI();
        inventoryPanel.SetActive(activeInventory);
        closeShop.onClick.AddListener(DeActiveShop);
    }

    private void SlotChange(int val)
    {
        for(int i = 0; i<slots.Length; i++)
        {
            slots[i].slotnum = i;
            
            if(i < inven.SlotCnt)
                slots[i].GetComponent<Button>().interactable = true;
            else
                slots[i].GetComponent<Button>().interactable = false;
 
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && !isStoreActive)
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
        if(Input.GetMouseButtonUp(0))
        RayShop();
    }

    public void AddSlot()
    {
        inven.SlotCnt++;
    }

    void RedrawSlotUI()
    {
        for(int i = 0; i<slots.Length; i++)
        {
            slots[i].RemoveSlot();
        }
        for(int i = 0; i < inven.items.Count; i++)
        {
            slots[i].item = inven.items[i];
            slots[i].UpdateSlotUI();
        }
    }
    
    public GameObject shop;
    public Button closeShop;
    public bool isStoreActive;

    public ShopData shopData;

    public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);
        if(hit2D.collider != null)
        {
            if(hit2D.collider.CompareTag("Store"))
            {
                if(!isStoreActive)
                {
                    ActiveShop(true);
                    shopData = hit2D.collider.GetComponent<ShopData>();
                    for(int i = 0; i<shopData.stocks.Count;i++)
                    {
                        shopSlots[i].item = shopData.stocks[i];
                        shopSlots[i].UpdateSlotUI();
                    }
                }
            }
            else if(hit2D.collider.CompareTag("Print"))
            {
                if(!isStoreActive)
                {
                    ActiveShop(true);
                    shopData = hit2D.collider.GetComponent<ShopData>();
                    for(int i = 0; i<1;i++)
                    {
                        shopSlots[i].item = shopData.stocks[i];
                        shopSlots[i].UpdateSlotUI();
                    }
                }
            }
        }
     }

     public void Buy(int num)
     {
        shopData.soldOuts[num] = true;
     }

     public void ActiveShop(bool isOpen)
     { 
        if(!activeInventory)
        {
            isStoreActive = isOpen;
            shop.SetActive(isOpen);
            inventoryPanel.SetActive(isOpen);
            for(int i = 0; i<slots.Length; i++)
            {
                slots[i].isShopMode = isOpen;
            }
        }
     }
     public void DeActiveShop()
     {
          ActiveShop(false);
          shopData = null;
          for(int i = 0; i<shopSlots.Length; i++)
          {
                shopSlots[i].RemoveSlot();
          }
     }

     public void SellBtn()
     {
        for(int i = slots.Length; i>0; i--)
        {
            slots[i-1].SellItem();
        }
     }
}


