using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautaFlutuando : MonoBehaviour
{
    public float velocidade = 2f;

    private Vector2 direcao;

    void Start()
    {
        direcao = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
    }

    void Update()
    {
        transform.Translate(direcao * velocidade * Time.deltaTime);

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0 || pos.x > 1)
            direcao.x *= -1;

        if (pos.y < 0 || pos.y > 1)
            direcao.y *= -1;
    }
}