using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tothe105 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player" && EnrolmentClass.lit == true)
        {
            for(int i = 0; i < Inventory.instance.items.Count; i++)
			{
				if(Inventory.instance.items[i].itemName.ToString().Equals("문학"))
                {
                    for(int j = 0; j < Inventory.instance.items.Count; j++)
					{
						if(Inventory.instance.items[j].itemName.ToString().Equals("빵"))
                        {
                            if (class_enter.literal == 0)
                            {
                                for(int a = Inventory.instance.items.Count; a >= 0; a-- )
								{
									if(i == a)
										Inventory.instance.RemoveItem(i);
									else if(j == a)
										Inventory.instance.RemoveItem(j);
								}
                                Debug.Log(collision.gameObject);
                                SceneManager.LoadScene("문학_notice");
                                WhatClass.classroom = 105;
                                class_enter.literal++;
                            }
                        }  
                    }
                }
            }
        }
    }
}
