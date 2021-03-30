using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotheClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player" && EnrolmentClass.history == true)
        {
            for(int i = 0; i < Inventory.instance.items.Count; i++)
			{
				if(Inventory.instance.items[i].itemName.ToString().Equals("역사"))
                {
                    if(class_enter.history == 0)
                    {
                        Inventory.instance.RemoveItem(i);
                        Debug.Log(collision.gameObject);
                        SceneManager.LoadScene("강의실");
                        class_enter.history++;
                    }
                }
            }           
        }

    }
}
