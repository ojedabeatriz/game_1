using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] private string cena;

    public void exit()
    {
        SceneManager.LoadScene(cena);

    }
    
}
