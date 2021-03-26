using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class literal_scoreboard : MonoBehaviour
{
    public Text ScriptTxt;
    // Start is called before the first frame update
    void Start()
    {
        if (literal_total.literalScore == 3)
        {
            ScriptTxt.text = "당신의 점수는 A입니다";
        }
        else if (literal_total.literalScore == 2)
        {
            ScriptTxt.text = "당신의 점수는 B입니다";
        }
        else if (literal_total.literalScore <= 1)
        {
            ScriptTxt.text = "당신의 점수는 C입니다";
        }
        scoreSum.sum += literal_total.literalScore;
    }
    
}
