using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class openPopup : MonoBehaviour {
 
    public GameObject popup;
    Vector2 MousePosition;
    Vector2 ObjectPosition;
    Camera Camera;
    public GameObject target;

    public void OnMouseDown(){
        popup.SetActive(true);
     }
     
 
    void Start () {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        ObjectPosition = target.transform.position;
    }
    
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;
            MousePosition = Camera.ScreenToWorldPoint(MousePosition);

            if(ObjectPosition == MousePosition)
                OnMouseDown();

        }
    }
}
