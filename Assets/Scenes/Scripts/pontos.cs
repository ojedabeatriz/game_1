using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontos : MonoBehaviour
{
    public int pontuacao;

    public AudioSource audioS;
    public AudioClip[] Sounds;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "pontuacao")
        {
            audioS.clip = Sounds[0];
            audioS.Play();
            Destroy(collision.gameObject);
            pontuacao++;
            pontosnatela.ponto.pontuacao = pontuacao;
        }

        
    }
}
