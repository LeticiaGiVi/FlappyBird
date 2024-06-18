using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coração : MonoBehaviour

{
    public int vida;
    public int vidaMax;

    public Image[] coracao;
    public Sprite cheio;
    public Sprite vazio;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SisVida();
    }

    void SisVida()
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

            if (i < vidaMax)
            {
                coracao[i].enabled = true;
            }

            else
            { coracao[i].enabled = false; }

        }


    }

}