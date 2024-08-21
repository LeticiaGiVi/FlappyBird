using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject selectedPrefab; 
    public GameObject playerPrefab;   
    private GameObject playerInstance; 

    private void Start()
    {
        //playerInstance = Instantiate(playerPrefab);

        playerInstance.GetComponent<SpriteRenderer>().sprite = selectedPrefab.GetComponent<SpriteRenderer>().sprite;


    }
}
