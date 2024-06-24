using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador_cereja : MonoBehaviour
{
  [SerializeField]
    private float tempoParaGerar;

    private float cronometro;

    [SerializeField]
    private GameObject modelObstaculo; 

    public SistemaCoracao sistemaCoracao;

    void Awake()
    {
        sistemaCoracao = GameObject.FindGameObjectWithTag("Player").GetComponent<SistemaCoracao>();
        this.cronometro = this.tempoParaGerar;
    }
    void Update()
    {
        this.cronometro -=Time.deltaTime;
        if(this.cronometro < 0 && sistemaCoracao.vida<sistemaCoracao.vidaMax)
        {
            GameObject.Instantiate(this.modelObstaculo, this.transform.position,Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
      }