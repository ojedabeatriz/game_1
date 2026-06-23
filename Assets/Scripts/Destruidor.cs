using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destruidor : MonoBehaviour
{
    [SerializeField] private string GameOverScene;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            Destroy(collider.gameObject);
            Invoke("LoadScene", 0f);
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(GameOverScene);
    }
}
