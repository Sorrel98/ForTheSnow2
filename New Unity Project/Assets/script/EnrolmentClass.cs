using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnrolmentClass : MonoBehaviour
{
    public bool history = false;
    public bool music = false;
    public bool lit = false;
    public bool art = false;
    public bool athletic = false;
    public bool ethics = false;

    public Button[] btnList;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enrolmentHistory()
    {
        history = true;
        btnList[0].GetComponent<Button>().interactable = false;
    }

    public void enrolmentArt()
    {
        art = true;
        btnList[1].GetComponent<Button>().interactable = false;
    }

    public void enrolmentLit()
    {
        lit = true;
        btnList[2].GetComponent<Button>().interactable = false;
    }

    public void enrolmentMusic()
    {
        music = true;
        btnList[3].GetComponent<Button>().interactable = false;
    }

    public void enrolmentAthletic()
    {
        athletic = true;
        btnList[4].GetComponent<Button>().interactable = false;
    }

    public void enrolmentEthics()
    {
        ethics = true;
        btnList[5].GetComponent<Button>().interactable = false;
    }
}
