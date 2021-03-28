using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tothe302 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player" && EnrolmentClass.athletic == true)
        {
            for(int i = 0; i < Inventory.instance.items.Count; i++)
            {
                if(Inventory.instance.items[i].itemName.ToString().Equals("체육"))
                {
                    for(int j = 0; j < Inventory.instance.items.Count; j++)
                    {
                        if(Inventory.instance.items[j].itemName.ToString().Equals("빵"))
                        {
                            for(int k= 0; k < Inventory.instance.items.Count; k++)
                            {
                                if(Inventory.instance.items[k].itemName.ToString().Equals("물"))
                                {
                                    for(int a = Inventory.instance.items.Count; a >= 0; a--)
                                    {
                                        if(i == a)
                                            Inventory.instance.RemoveItem(i);
                                        else if(j == a)
                                            Inventory.instance.RemoveItem(j);
                                        else if(k == a)
                                            Inventory.instance.RemoveItem(k);
                                    }
                                    Debug.Log(collision.gameObject);
                                    SceneManager.LoadScene("체육_notice");
                                    WhatClass.classroom = 302;
                                }
                            }
                        }
                    }
                }
            }

        }

    }
}
