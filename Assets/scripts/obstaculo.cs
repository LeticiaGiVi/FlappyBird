using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    public float velocidade = 1.8f;

    [SerializeField]
    public float variacaoY = 2f;

    [SerializeField]
    private GameObject modelObstaculo;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Start()
    {
        GameObject.Instantiate(this.modelObstaculo, this.transform.position, Quaternion.identity);
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
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