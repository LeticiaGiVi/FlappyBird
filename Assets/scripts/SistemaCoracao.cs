using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaCoracao : MonoBehaviour
{
    public int vida = 3;
    public int vidaMax = 3;

    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;

    private Diretor diretor;

    void Start()
    {
        diretor = FindObjectOfType<Diretor>();
    }

    void Update()
    {
        SisVida();
    }

    public void SisVida()
    {
        if (vida > vidaMax)
        {
            vida = vidaMax;
        }

        for (int i = 0; i < coracao.Length; i++)
        {
            if (i < vida)
            {
                coracao[i].sprite = cheio;
            }
            else
            {
                coracao[i].sprite = vazio;
            }

            coracao[i].enabled = i < vidaMax;
        }
    }


    private void FinalizarJogo()
    {
        if (diretor != null)
        {
            diretor.FinalizarJogo();
        }
    }
}