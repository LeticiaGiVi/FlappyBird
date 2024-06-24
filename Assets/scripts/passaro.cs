using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passaro : MonoBehaviour
{
    Rigidbody2D fisica;

    public SistemaCoracao sistemaCoracao;
    private Diretor diretor;
       private Vector3 posicaoInicial;

       void Start(){
            this.diretor = FindObjectOfType<Diretor>();
       }

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
 if (sistemaCoracao != null && sistemaCoracao.vida <= 0)
    {
        if (diretor != null)
        {
            this.diretor.FinalizarJogo();
        }
     }   

    }
    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up*3,ForceMode2D.Impulse);
    }
    public void Reiniciar(){
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
