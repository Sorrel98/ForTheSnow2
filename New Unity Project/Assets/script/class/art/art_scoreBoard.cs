using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class art_scoreBoard : MonoBehaviour
{
    public Text ScriptTxt;
    // Start is called before the first frame update
    void Start()
    {
        if (art_total.artScore == 4 || art_total.artScore == 5)
        {
            ScriptTxt.text = "당신의 점수는 A입니다";
        }
        else if (art_total.artScore == 2 || art_total.artScore == 3)
        {
            ScriptTxt.text = "당신의 점수는 B입니다";
        }
        else if (art_total.artScore <= 1)
        {
            ScriptTxt.text = "당신의 점수는 C입니다";
        }
        scoreSum.sum += art_total.artScore;
        scoreSum.CountUp();
    }
    
}
