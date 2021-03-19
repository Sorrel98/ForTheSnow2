using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class his_talk : MonoBehaviour
{
    public GameObject o;
    public GameObject x;
    public GameObject talk1;
    public GameObject talk2;
    public GameObject talk3;
    public GameObject talk4;
    public GameObject talk5;
    
    
    // Start is called before the first frame update
    void Start()
    {
        talk1.SetActive(true);
        talk2.SetActive(false);
        talk3.SetActive(false);
        talk4.SetActive(false);
        talk5.SetActive(false);
    }

    // Update is called once per frame

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Ray2D ray = new Ray2D(wp, Vector2.zero);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                Debug.Log("collider hit");
                if (history_score.historyNum == 1)
                {
                    if (hit.collider.CompareTag("o")) //오답
                    {
                        history_score.historyNum++;
                        Debug.Log("오답입니다");
                    }
                    else if (hit.collider.CompareTag("x")) //정답
                    {
                        history_score.historyNum++;
                        history_score.historyScore++;
                        Debug.Log("정답입니다");
                    }
                    talk1.SetActive(false);
                    talk2.SetActive(true);
                }
                else if (history_score.historyNum == 2)
                {
                    if (hit.collider.CompareTag("o")) //정답
                    {
                        history_score.historyNum++;
                        history_score.historyScore++;
                        Debug.Log("정답입니다");
                    }
                    else if (hit.collider.CompareTag("x")) //오답
                    {
                        history_score.historyNum++;
                        Debug.Log("오답입니다");
                    }
                    talk2.SetActive(false);
                    talk3.SetActive(true);
                }
                else if (history_score.historyNum == 3)
                {
                    if (hit.collider.CompareTag("o")) //오답
                    {
                        history_score.historyNum++;
                        Debug.Log("오답입니다");
                    }
                    else if (hit.collider.CompareTag("x")) //정답
                    {
                        history_score.historyNum++;
                        history_score.historyScore++;
                        Debug.Log("정답입니다");
                    }
                    talk3.SetActive(false);
                    talk4.SetActive(true);
                }
                else if (history_score.historyNum == 4)
                {
                    if (hit.collider.CompareTag("o")) //오답
                    {
                        history_score.historyNum++;
                        Debug.Log("오답입니다");
                    }
                    else if (hit.collider.CompareTag("x")) //정답
                    {
                        history_score.historyNum++;
                        history_score.historyScore++;
                        Debug.Log("정답입니다");
                    }

                    talk4.SetActive(false);
                    talk5.SetActive(true);
                }
                else if (history_score.historyNum == 5)
                {
                    if (hit.collider.CompareTag("o")) //정답
                    {
                        history_score.historyNum++;
                        history_score.historyScore++;
                        Debug.Log("정답입니다");
                    }
                    else if (hit.collider.CompareTag("x")) //오답
                    {
                        history_score.historyNum++;
                        Debug.Log("오답입니다");
                    }
                    //성적표 씬 체인지
                }
            }
        }
            
    }

}
