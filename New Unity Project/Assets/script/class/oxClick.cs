using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxClick : MonoBehaviour
{

    //public GameObject popup;
    Vector2 MousePosition;
    Vector2 ObjectPosition1;
    Vector2 ObjectPosition2;
    Camera Camera;
    public GameObject target1;
    public GameObject target2;

    // Start is called before the first frame update

    void OnMouseDown()
    {
        //Debug.Log("open");
        //popup.SetActive(true);
    }

        // Use this for initialization
    void Start()
    {
        Camera = GameObject.Find("Camera").GetComponent<Camera>();
        ObjectPosition1 = target1.transform.position;
        ObjectPosition2 = target2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("마우스눌림");
            //MousePosition = Input.mousePosition;
            //MousePosition = Camera.ScreenToWorldPoint(MousePosition);
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log(ray);
            if(Physics.Raycast(ray, out hit, 10000f))
            {
                MousePosition = hit.point;
                Debug.Log("ObjectPosition1 : " + ObjectPosition1);
                Debug.Log("ObjectPosition2 : " + ObjectPosition2);
                Debug.Log("Mouse : " + MousePosition);
            }
            
            if (ObjectPosition1 == MousePosition)
            {
                //OnMouseDown();
                Debug.Log("object1");
            }
            else if(ObjectPosition2 == MousePosition)
            {
                Debug.Log("object2");
            }
        }
    }
}