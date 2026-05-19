using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcoes : MonoBehaviour
{
    [SerializeField] private string cena;
    [SerializeField] private GameObject menuinicial;
    [SerializeField] private GameObject menuopcoes;

    public void Startjogar()
    {
        SceneManager.LoadScene(cena);

    }

    public void inicioopcoes()
    {
        menuinicial.SetActive(false);
        menuopcoes.SetActive(true);
    }

    public void sairopcoes()
    {
        menuopcoes.SetActive(false);
        menuinicial.SetActive(true);
    }
    
    public void Exit()
    {
        Debug.Log("Sair do jogo!");
        Application.Quit();
    }
}