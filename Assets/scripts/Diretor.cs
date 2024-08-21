using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private passaro passaro;

    void Start()
    {
        this.passaro = FindObjectOfType<passaro>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        if (imagemGameOver != null)
        {
            imagemGameOver.SetActive(true);
        }
    }

    public void ReiniciarJogo()
    {
        imagemGameOver.SetActive(true);
        Time.timeScale = 1;
        passaro.Reiniciar();
        SistemaCoracao coracao = FindObjectOfType<SistemaCoracao>();
        if (coracao != null)
        {
            coracao.vida = coracao.vidaMax;
            coracao.SisVida();
        }
    }
}