using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar=3;

    private float cronometro;

    [SerializeField]
    private GameObject modelObstaculo; 

    void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }
    void Update()
    {
        this.cronometro -=Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modelObstaculo, this.transform.position,Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
