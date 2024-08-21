using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SelecionadorPersonagem : MonoBehaviour
{

    private UIDocument document;
    private Button botaoBack;
    private Button botaoNext;
    private Button botaoEscolher;

    public SpriteRenderer sr;
    public List<GameObject> skins = new List<GameObject>();
    private int selectedSkin = 0;
    public GameObject playerskin;

    public GameObject playerSkinInstance;
    void NextOption(ClickEvent evt)
    {
        if (playerSkinInstance != null)
        {
            Destroy(playerSkinInstance);
        }
        selectedSkin = (selectedSkin + 1) % skins.Count;
        playerSkinInstance = Instantiate(skins[selectedSkin], transform.position, Quaternion.identity);
        playerSkinInstance.transform.SetParent(transform);
    }

    void BackOption(ClickEvent evt)
    {
        if (playerSkinInstance != null)
        {
            Destroy(playerSkinInstance);
        }
        selectedSkin = (selectedSkin - 1 + skins.Count) % skins.Count;
        playerSkinInstance = Instantiate(skins[selectedSkin], transform.position, Quaternion.identity);
        playerSkinInstance.transform.SetParent(transform);
    }
    void OnMenu(ClickEvent evt)
    {
        if (playerSkinInstance != null)
        {
            playerskin = playerSkinInstance;

            PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/SkinSelecionada.prefab");
        }
        SceneManager.LoadScene("Menu");

    }

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botaoBack = document.rootVisualElement.Q<Button>("back");
        botaoNext = document.rootVisualElement.Q<Button>("next");
        botaoEscolher = document.rootVisualElement.Q<Button>("escolher");
        botaoBack.RegisterCallback<ClickEvent>(BackOption);
        botaoNext.RegisterCallback<ClickEvent>(NextOption);
        botaoEscolher.RegisterCallback<ClickEvent>(OnMenu);
    }
}
