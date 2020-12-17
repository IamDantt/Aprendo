using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gestor : MonoBehaviour
{
    public GameObject[] Profesiones;
    public GameObject[] ProfesionesText;
    public GameObject Panel,Win,Lose,PanelText;
    public GameObject Game;
   

   
    List <int> numerosGuardados = new List<int> ();
    int item;

    void Start()
    { 
  
        Game.SetActive(true);
 
        for(int i=0; i<3; i++){
            do {
          item = Random.Range(0,8);
         } while (numerosGuardados.Contains(item));
         numerosGuardados.Add(item);
          Instantiate (Profesiones[item],Panel.transform);
        }
        do {
          item = Random.Range(0,8);
         } while (numerosGuardados.Contains(item));
          numerosGuardados.Add(item);
           Instantiate (Profesiones[item],Panel.transform);
           Instantiate (ProfesionesText[item],PanelText.transform);
    }
    void Update(){
       int score = PlayerPrefs.GetInt("CheckScore");
       Debug.Log(score);
       if(score==1){
          Win.SetActive(true);
       }
       if(score == 2){
          Lose.SetActive(true);
       }
    }


public void Restart(){
    PlayerPrefs.SetInt("CheckScore",0);
}


}