using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Diretor : MonoBehaviour
{
    private UIDocument document;
    private Button botaoJogar;
    private Button botaoMudar;

    private passaro passaro;

    void Start()
    {
        this.passaro = FindObjectOfType<passaro>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
            document = GetComponent<UIDocument>();

    }
}