using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] private string NomedoLeveldejogo;
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Opcoes;

    public void Play()
    {
        SceneManager.LoadScene("Fase 1");
    }
    
    public void AbrirOpcoes()
    {
        Opcoes.SetActive(true);
    }

    public void Exitmenu()
    {
        Opcoes.SetActive(false);
    }

    public void Sair()
    {
        Application.Quit();
    }
  


}
