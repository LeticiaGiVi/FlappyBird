using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{

    public SistemaCoracao coracao;
    private Diretor diretor;
    public SistemaCoracao sistemaCoracao;

        void Start()
    {
        diretor = FindObjectOfType<Diretor>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SistemaCoracao coracao = collision.gameObject.GetComponent<SistemaCoracao>();
        if (coracao != null)
        {
            coracao.vida--;
            coracao.SisVida();
        }
        if (coracao.vida <= 0)
        {
            diretor.FinalizarJogo();
        }
    }
}
