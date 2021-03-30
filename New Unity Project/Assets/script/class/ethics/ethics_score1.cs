using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ethics_score1 : MonoBehaviour
{
    public Text ScriptTxt;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("총 점수 : " + ethics_score.ethicsScore);
        if (ethics_score.ethicsScore == 3)
        {
            ScriptTxt.text = "당신의 점수는 A입니다";
        }
        else if (ethics_score.ethicsScore == 2)
        {
            ScriptTxt.text = "당신의 점수는 B입니다";
        }
        else if (ethics_score.ethicsScore == 0|| ethics_score.ethicsScore==1)
        {
            ScriptTxt.text = "당신의 점수는 C입니다";
        }
        scoreSum.sum += finish.score;
        scoreSum.CountUp();
    }

}
