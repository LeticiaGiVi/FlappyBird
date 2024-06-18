using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fumaça : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.9f;

    [SerializeField]
    public float varairposicaoY;

    [SerializeField]

    public float tempoParaGerar = 3;

    public float cronometro;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-varairposicaoY, varairposicaoY));
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

    }
}
