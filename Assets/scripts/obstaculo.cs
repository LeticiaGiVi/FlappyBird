using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{


    [SerializeField]
    private float velocidade ;

    [SerializeField]
    private float variacaoY;

    private Vector3 posicaopassaro;

    private UIControler controladorUI;

    private bool pontuei;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Start()
    {
        this.posicaopassaro = GameObject.FindObjectOfType<passaro>().transform.position;
        this.controladorUI =  GameObject.FindObjectOfType<UIControler>();
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
        if(!this.pontuei && this.transform.position.x < this.posicaopassaro.x)
        {
            this.controladorUI.AdicionarPontos();
            this.pontuei = true;
        }
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