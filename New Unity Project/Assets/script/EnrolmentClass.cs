using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnrolmentClass : MonoBehaviour
{
    public bool history = false;
    public bool music = false;
    public bool lit = false;
    public bool art = false;
    public bool athletic = false;
    public bool ethics = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enrolment(Collider other)
    {
        if(other.gameObject.CompareTag("history"))
        {
            Debug.Log("change");
            history = true;
            Debug.Log(history);
        }
        else if(CompareTag("history"))
        {
            history = true;
        }
    }
}
