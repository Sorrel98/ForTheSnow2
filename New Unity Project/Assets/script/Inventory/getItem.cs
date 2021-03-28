using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getItem : MonoBehaviour
{
    Vector2 MousePosition;
    Vector2 ObjectPosition;
    Camera Camera;
    public GameObject target;

	public List<Item>itemDB = new List<Item>();
    public GameObject fieldItemPrefab;
    public Vector2[] pos;

    void OnMouseDown(){
        Debug.Log("get");
		GameObject go = Instantiate(fieldItemPrefab, pos[1], Quaternion.identity);
		go.GetComponent<FieldItems>().SetItem(itemDB[1]);
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
