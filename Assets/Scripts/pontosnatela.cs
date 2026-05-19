using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pontosnatela : MonoBehaviour
{
    public static pontosnatela ponto;

    public TMP_Text pontotexto; 
    public int pontuacao;
    
    void Awake(){
        if(ponto == null)
        {
           ponto = this;
        }
       else if(ponto != this)
        {
           Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        pontotexto.text = pontuacao.ToString();

    }
}
