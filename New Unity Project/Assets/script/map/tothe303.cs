using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tothe303 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player" && EnrolmentClass.ethics == true)
        {
            for(int i = 0; i < Inventory.instance.items.Count; i++)
            {
                if(Inventory.instance.items[i].itemName.ToString().Equals("윤리"))
                {
                    Inventory.instance.RemoveItem(i);
                    Debug.Log(collision.gameObject);
                    SceneManager.LoadScene("윤리_notice");
                    WhatClass.classroom = 303;
                }
            }
        }

    }
}
