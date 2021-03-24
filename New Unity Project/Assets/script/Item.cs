using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
	Coin,
	Bread,
	Water,
	Paper,
	Enrolment,
	FreePaper,
	FreeBread,
	FreeCoin
}

[System.Serializable]
public class Item 
{
	public ItemType itemType;
	public string itemName;
	public int itemCost;
	public Sprite itemImage;
	public List<ItemEffect> efts;

	public bool Use()
	{
		bool isUsed = false;
		foreach(ItemEffect eft in efts)
		{
			isUsed = eft.ExecuteRole();
		}

		return isUsed;
	}
}
