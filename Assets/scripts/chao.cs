using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posicaoInicial;

    private float tamanhoReal;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        tamanhoReal = tamanhoDaImagem * escala;
    }

    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoReal);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;

    }
}