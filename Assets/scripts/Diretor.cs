using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
   [SerializeField]
   private GameObject imagemGameOver;
   private passaro passaro;
   
   private void Start(){
     this.passaro = FindObjectOfType<passaro>();
   }
   public void FinalizarJogo(){
       Time.timeScale = 0;
       this.imagemGameOver.SetActive(true);
   }
   private void ReiniciarJogo(){
       this.imagemGameOver.SetActive(false);
       Time.timeScale = 1;
       this.passaro.Reiniciar();
   }
}