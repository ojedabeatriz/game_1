using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    [SerializeField] private string VitoriaScene;

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.CompareTag("Player"))
        {
            SceneManager.LoadScene(VitoriaScene);
        }
    }
}
