using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fumaca : MonoBehaviour
{
public obstaculo obstaculo;



    void Update()
    {
        this.transform.Translate(Vector3.left * obstaculo.velocidade * Time.deltaTime);
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
