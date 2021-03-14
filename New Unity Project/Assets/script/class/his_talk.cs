using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class his_talk : MonoBehaviour
{
    public GameObject Talk1;
    public GameObject Talk2;
    public GameObject Talk3;
    public GameObject Talk4;
    public GameObject Talk5;
    public GameObject O;
    public GameObject X;
    // Start is called before the first frame update
    void Start()
    {
        Talk1.SetActive(false);
        Talk2.SetActive(false);
        Talk3.SetActive(false);
        Talk4.SetActive(false);
        Talk5.SetActive(false);
        O.SetActive(true);
        X.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
