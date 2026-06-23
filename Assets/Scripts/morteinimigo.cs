using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morteinimigo : MonoBehaviour
{
    public float forca;
    private bool stomp = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRb = collider.GetComponent<Rigidbody2D>();
            playerRb.AddForce(new Vector2(0f, forca), ForceMode2D.Impulse);
            stomp = true;

            BoxCollider2D deseboxcollider = transform.parent.gameObject.GetComponent<BoxCollider2D>();
            deseboxcollider.enabled = false;
        }
    }

    private void OnBecameInvisible()
    {
        if(stomp == true)
        {
            Destroy(transform.parent.gameObject);
        }
    }      

}
