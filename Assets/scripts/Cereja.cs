using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cereja : MonoBehaviour
{
[SerializeField]
    private float velocidade ;

    [SerializeField]
    private float variacaoY;

    private Vector3 posicaopassaro;

    public SistemaCoracao coracao;

    private void OnCollisionEnter2D(Collision2D collision)
    {
   SistemaCoracao coracao = collision.gameObject.GetComponent<SistemaCoracao>();
            if (coracao != null)
            {
                coracao.vida++;
                coracao.SisVida();
                 this.Destruir();

            }
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Start()
    {
        this.posicaopassaro = GameObject.FindObjectOfType<passaro>().transform.position;
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
