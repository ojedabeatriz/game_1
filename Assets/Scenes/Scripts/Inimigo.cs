using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public float velocidade;
    public Rigidbody2D  inimigoRb;
    private bool face;

    void Update()
    {
        
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
        
    }

    private void Flipinimigo()
    {
        if (face)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col != null && !col.collider.CompareTag("Player")  && !col.collider.CompareTag("chao"))
        {
            face = !face;
        }
        
        Flipinimigo();
    }

  



}
