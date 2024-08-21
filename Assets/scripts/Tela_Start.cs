using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Tela_Start : MonoBehaviour
{
    private UIDocument document;
    private Button botaoJogar;
    private Button botaoMudar;

    void OnPlayGame(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }

    void OnChangeSkin(ClickEvent evt)
    {
        SceneManager.LoadScene("Troca-personagem");
    }
    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botaoJogar = document.rootVisualElement.Q<Button>("start");
        botaoMudar = document.rootVisualElement.Q<Button>("mudarPerssonagem");
        botaoJogar.RegisterCallback<ClickEvent>(OnPlayGame);
        botaoMudar.RegisterCallback<ClickEvent>(OnChangeSkin);
    }
}
