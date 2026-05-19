using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.CompareTag("Player"))
        {
            SceneManager.LoadScene("Vitoria");
        }
    }
}
