using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    public GameObject Game,Win,Lose;
    public Text UIText;
    public InputField InputName;
    public GameObject[] animals;
    public GameObject[] animalsBlack;
    public GameObject GroupAnimals,GroupAnimalsBlack,TryAgainT;
    public GameObject Collider1,Collider2,Collider3,Collider4;
    int Animal,CheckNameI, Score1, Score2, Score3,Score4,scoreCheck;
    //public float time = 30;

    Trigg trigg;
    Trigg2 trigg2;
    Trigg3 trigg3;
    Trigg4 trigg4;
    
    public List <int> numerosGuardados = new List<int> ();
    
    
    void Start()
    {
      CheckNameI=PlayerPrefs.GetInt("CheckName");   
      if(CheckNameI==1){

         Game.SetActive(true);
      }
      else{
         Game.SetActive(false);
      }
       instantiateAnimals();
       trigg= Collider1.GetComponent<Trigg>();
       trigg2= Collider2.GetComponent<Trigg2>();
       trigg3= Collider3.GetComponent<Trigg3>();
       trigg4= Collider4.GetComponent<Trigg4>();

       Win.SetActive(false);
       Lose.SetActive(false);
     TryAgainT.SetActive(false);
       
    }

    void Update()
    {
       //time -= Time.deltaTime;
       //UIText.text = time.ToString("f0");
       Score1 = trigg.puntuacion;
       Score2 = trigg2.puntuacion2;
       Score3 = trigg3.puntuacion3;
       Score4 = trigg4.puntuacion4;
       scoreCheck = Score1 + Score2 + Score3 + Score4;    

       /*if(time<=0 && scoreCheck !=4){
          Lose.SetActive(true); 
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Error);
        }
       else if ( time<=0  && scoreCheck == 4){
          Win.SetActive(true);
       }*/
       
    }
     public void TryAgain(){
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Confirm);
        SceneManager.LoadScene(2);
        
    }

    public void checkComplete(){

        if (scoreCheck == 4) {
            Win.SetActive(true);
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Confirm);
        }
        else {
            TryAgainT.SetActive(true);
            StartCoroutine("Wait");
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Error);

        }       
    }

   public void instantiateAnimals()
   {
      for (int i=0; i<4; i++){
      do {
          Animal = Random.Range(0,7);
         } while (numerosGuardados.Contains(Animal));
         numerosGuardados.Add(Animal);
         Instantiate (animals[Animal],GroupAnimals.transform);
         Instantiate (animalsBlack[Animal],GroupAnimalsBlack.transform);     
      } 

     
            
   }

   public void SaveName(){
       if(!string.IsNullOrEmpty(InputName.text ))
     PlayerPrefs.SetString("Name", InputName.text);
     PlayerPrefs.SetInt("CheckName",1);
   }
    IEnumerator Wait(){
       yield return new WaitForSeconds(4);
       TryAgainT.SetActive(false);
       
    }
}
