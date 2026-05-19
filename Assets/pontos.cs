using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontos : MonoBehaviour
{
    public int pontuacao ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pontuacao")
        {
            Destroy(collision.gameObject);
            pontuacao++;
        }
    }
}
