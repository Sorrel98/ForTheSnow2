using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePopup : MonoBehaviour
{
    public GameObject popup;

     public void OnMouseDown(){
        Debug.Log("close");
        popup.SetActive(false);
     }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
