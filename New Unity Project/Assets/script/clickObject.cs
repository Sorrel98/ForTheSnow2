using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class clickObject : MonoBehaviour {
 
    Vector2 MousePosition;
    Vector2 ObjectPosition;
    Camera Camera;
    public GameObject target;
    // Start is called before the first frame update


    //write here what to do
    void OnMouseDown(){
        Debug.Log("click");
        
     }
     
 
    // Use this for initialization
    void Start () {
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        ObjectPosition = target.transform.position;
    }
    
    // Update is called once per frame
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
