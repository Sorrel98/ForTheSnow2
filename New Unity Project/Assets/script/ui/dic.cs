
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dic : MonoBehaviour
{
    public GameObject Target;
    // Start is called before the first frame update
    public void Start()
    {
        Target.SetActive(false);
    }

    // Update is called once per frame
    public void dicStart()
    {
        bool isview = !Target.activeSelf;
        Target.SetActive(isview);
    }
    
    
}
