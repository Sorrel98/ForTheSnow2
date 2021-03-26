using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class REBUTTON : MonoBehaviour
{
    public GameObject rebtn;
    Button btback;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;

    public GameObject input;

    public GameObject notebook;


    // Start is called before the first frame update
    void Start()
    {
        btback = rebtn.transform.GetComponent<Button>();
        btback.onClick.AddListener(Clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Clicked()
    {
        if(literal_total.literalNum == 1)
        {
            target1.SetActive(true);
            rebtn.SetActive(false);
            notebook.SetActive(false);
            input.SetActive(false);
            target4.SetActive(false);
        }
        else if (literal_total.literalNum == 2)
        {
            target2.SetActive(true);
            rebtn.SetActive(false);
            notebook.SetActive(false);
            input.SetActive(false);
            target4.SetActive(false);
        }
        else if (literal_total.literalNum == 3)
        {
            target3.SetActive(true);
            rebtn.SetActive(false);
            notebook.SetActive(false);
            input.SetActive(false);
            target4.SetActive(false);
        }
    }
}
