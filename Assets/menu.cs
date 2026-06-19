using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] private string NomedoLeveldejogo;
    public void Play()
    {
        SceneManager.LoadScene("Fase 1");
    }
}
