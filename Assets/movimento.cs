using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    private float horizonteInput;
    private Rigidbody2D rb;
    public bool isGameOver = false;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
       isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
         horizonteInput = Input.GetAxis("Horizontal");

         if(Input.GetKeyDown(KeyCode.Space))
         {
             rb.AddForce(Vector2.up * 500);
         }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizonteInput * 5, rb.velocity.y);
    }
}
