using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passaro : MonoBehaviour
{
    Rigidbody2D fisica;

    public SistemaCoracao sistemaCoracao;
    private Diretor diretor;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
        this.diretor = FindObjectOfType<Diretor>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
        if (sistemaCoracao.vida <= 0)
        {
            this.diretor.FinalizarJogo();
        }

    }
    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up*3,ForceMode2D.Impulse);
    }
}
