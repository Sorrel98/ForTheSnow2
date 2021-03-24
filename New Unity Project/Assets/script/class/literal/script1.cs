using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public GameObject script;
    public GameObject notebook;
    public GameObject re;
    public GameObject input;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            script.SetActive(false);
            notebook.SetActive(true);
            re.SetActive(true);
            input.SetActive(true);
        }
    }
}
