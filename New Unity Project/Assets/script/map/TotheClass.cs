using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotheClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Debug.Log(collision.gameObject);
<<<<<<< Updated upstream
            SceneManager.LoadScene("강의실");
=======
            SceneManager.LoadScene("컴퓨터실");
            
>>>>>>> Stashed changes
        }

    }
}
