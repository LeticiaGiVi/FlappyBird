using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morte : MonoBehaviour
{
    public SistemaCoracao coracao;

    private void OnCollisionEnter2D(Collision2D collision)
    {
   SistemaCoracao coracao = collision.gameObject.GetComponent<SistemaCoracao>();
            if (coracao != null)
            {
                coracao.vida-=3;
                coracao.SisVida();
            }
    }
}
