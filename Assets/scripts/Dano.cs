using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public SistemaCoracao coracao;

    private void OnCollisionEnter2D(Collision2D collision)
    {
   SistemaCoracao coracao = collision.gameObject.GetComponent<SistemaCoracao>();
            if (coracao != null)
            {
                coracao.vida--;
                coracao.SisVida();
            }
    }
}
