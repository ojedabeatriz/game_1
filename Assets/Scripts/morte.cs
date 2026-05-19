using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Invoke("LoadScene", 0f);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene("MenuGameOver");
    }
}
