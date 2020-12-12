using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gestor : MonoBehaviour
{
    public GameObject[] Profesiones;
    public GameObject Panel,Win,Lose,Astro;
    public GameObject Game, FirstPant;
    public InputField InputName;
    public Text  textName;

    // Text

    public GameObject PanelText;
    public GameObject[] TextProf;


    List <int> numerosGuardados = new List<int> ();
    int item, CheckNameI;

    void Start()
    { 
      textName.text =  PlayerPrefs.GetString("NameP");
      Astro = GameObject.FindWithTag("Astronauta");
      CheckNameI=PlayerPrefs.GetInt("CheckNameP");   
      if(CheckNameI==1){

         Game.SetActive(true);
         FirstPant.SetActive(false);
      }
      else{
         Game.SetActive(false);
         FirstPant.SetActive(true);
      }



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
           Instantiate (TextProf[item],PanelText.transform);
           Instantiate (Profesiones[item],Panel.transform);
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
   public void SaveName(){
       if(!string.IsNullOrEmpty(InputName.text )){
       PlayerPrefs.SetString("NameP", InputName.text);
       PlayerPrefs.SetInt("CheckNameP",1);
       textName.text =  PlayerPrefs.GetString("NameP");
   }
}

public void Restart(){
    PlayerPrefs.SetInt("CheckScore",0);
    SceneManager.LoadScene(2);
}


}