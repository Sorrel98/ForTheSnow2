using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopSlot : MonoBehaviour, IPointerUpHandler
{
	public int slotnum;
	public Item item;
	public Image itemIcon;
	public bool soldOut = false;
	public bool coinSoldOut = false;
	InventoryUI inventoryUI;

	public void Init(InventoryUI Iui)
	{
		inventoryUI = Iui;
	}

	public void UpdateSlotUI()
	{
		itemIcon.sprite = item.itemImage;
		itemIcon.gameObject.SetActive(true);
		if(soldOut)
		{
			//itemIcon.color = new Color(0.5f, 0.5f, 0.5f);
			itemIcon.gameObject.SetActive(false);
		}
	}
	public void RemoveSlot()
	{
		item = null;
		soldOut = false;
		itemIcon.gameObject.SetActive(false);
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		if(item != null)
		{
			if(ItemDatabase.instance.money >= item.itemCost && !soldOut && Inventory.instance.items.Count < Inventory.instance.SlotCnt)
			{
				/*ItemDatabase.instance.money -= item.itemCost;
				Inventory.instance.AddItem(item);
				//soldOut = true;
				inventoryUI.Buy(slotnum);
				UpdateSlotUI();*/
				if(item.itemType.ToString().Equals("Enrolment"))
				{
					for(int i = 0; i < Inventory.instance.items.Count; i++)
					{
						if(Inventory.instance.items[i].itemName.ToString().Equals("코인"))
						{
							for(int j = 0; j < Inventory.instance.items.Count; j++)
							{
								if(Inventory.instance.items[j].itemName.ToString().Equals("종이"))
								{
									for(int a = Inventory.instance.items.Count; a >= 0; a--)
									{
										if(i == a)
											Inventory.instance.RemoveItem(i);
										else if(j == a)
											Inventory.instance.RemoveItem(j);
									}
									Inventory.instance.AddItem(item);
									inventoryUI.Buy(slotnum);
									UpdateSlotUI();
									break;
								}
							}
							break;
						}
					}
				}
				else if(item.itemType.ToString().Equals("Bread"))
				{
					for(int i = 0; i < Inventory.instance.items.Count; i++)
					{
						if(Inventory.instance.items[i].itemType.ToString().Equals("Coin") || Inventory.instance.items[i].itemType.ToString().Equals("FreeCoin"))
						{
							Inventory.instance.RemoveItem(i);
							Inventory.instance.AddItem(item);
							Inventory.instance.AddItem(item);
							inventoryUI.Buy(slotnum);
							UpdateSlotUI();
							break;
						}
					}
				}
				else if(item.itemType.ToString().Equals("Paper"))
				{
					for(int i = 0; i < Inventory.instance.items.Count; i++)
					{
						if(Inventory.instance.items[i].itemType.ToString().Equals("Coin") || Inventory.instance.items[i].itemType.ToString().Equals("FreeCoin"))
						{
							Inventory.instance.RemoveItem(i);
							Inventory.instance.AddItem(item);
							Inventory.instance.AddItem(item);
							Inventory.instance.AddItem(item);
							Inventory.instance.AddItem(item);
							Inventory.instance.AddItem(item);
							inventoryUI.Buy(slotnum);
							UpdateSlotUI();
							break;
						}
					}
				}
				else if(item.itemType.ToString().Equals("Coin"))
				{
					Inventory.instance.AddItem(item);
					inventoryUI.Buy(slotnum);
					coinSoldOut = true;
					UpdateSlotUI();
					
				}
				else if(item.itemType.ToString().Equals("Water"))
				{
					Inventory.instance.AddItem(item);
					inventoryUI.Buy(slotnum);
					UpdateSlotUI();
				}
				else if(item.itemType.ToString().Equals("FreePaper"))
				{
					soldOut = false;
					UpdateSlotUI();
					Inventory.instance.AddItem(item);
					inventoryUI.Buy(slotnum);
					soldOut = true;
					UpdateSlotUI();
				}
				else if(item.itemType.ToString().Equals("FreeBread"))
				{
					soldOut = false;
					UpdateSlotUI();
					Inventory.instance.AddItem(item);
					inventoryUI.Buy(slotnum);
					soldOut = true;
					UpdateSlotUI();
				}
				else if(item.itemType.ToString().Equals("FreeCoin"))
				{
					Inventory.instance.AddItem(item);
					inventoryUI.Buy(slotnum);
					soldOut = true;
					UpdateSlotUI();
				}
			}
		}	
	}
}