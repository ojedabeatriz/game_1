using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public GameObject teto;
    public GameObject Movimento;
    
    private void OnTriggerEnter(Collider other)
    {
        if (Movimento.GetComponent<movimento>().isGameOver)
        {
            Movimento.GetComponent<movimento>().isGameOver = true;
            Debug.Log("Game Over!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
