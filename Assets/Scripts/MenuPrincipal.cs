using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcoes : MonoBehaviour
{
    [SerializeField] private string cena;
    [SerializeField] private string sair;
    [SerializeField] private string restart;

    public void Startjogar()
    {
        SceneManager.LoadScene(cena);

    }

    public void Restart()
    {
        SceneManager.LoadScene(restart);
    }

    public void Exit()
    {
        SceneManager.LoadScene(sair);
    }
}