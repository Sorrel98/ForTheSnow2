using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotheUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Debug.Log(collision.gameObject);
            SceneManager.LoadScene("1층_위");
        }

    }
}
