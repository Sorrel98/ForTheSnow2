using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class history_scoreboard : MonoBehaviour
{
    public Text ScriptTxt;
    // Start is called before the first frame update
    void Start()
    {
        if (history_score.historyScore == 4 || history_score.historyScore == 5)
        {
            ScriptTxt.text = "당신의 점수는 A입니다";
        }
        else if (history_score.historyScore == 2 || history_score.historyScore == 3)
        {
            ScriptTxt.text = "당신의 점수는 B입니다";
        }
        else if (history_score.historyScore <= 1)
        {
            ScriptTxt.text = "당신의 점수는 C입니다";
        }
        scoreSum.sum += history_score.historyScore;
    }
}
