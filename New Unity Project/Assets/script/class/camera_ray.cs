using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ray : MonoBehaviour
{
    Camera cam;
    Vector3 MousePosition;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Input.mousePosition;
            MousePosition.z = 5.0f;
            MousePosition = cam.ScreenToWorldPoint(MousePosition);
            
            RaycastHit2D hit = Physics2D.Raycast(MousePosition, transform.forward, 15f);
            Debug.Log("되는건가");
            Debug.Log(hit);
            if (hit)
            {
                Debug.Log("대체 언제");
            }
        }
    }
}
