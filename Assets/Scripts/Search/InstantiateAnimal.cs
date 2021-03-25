using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAnimal : MonoBehaviour
{
    [SerializeField]
    List <GameObject> Animals;
    [SerializeField]
    List <GameObject> AnimalsInstantiate;
    [SerializeField]
    List <GameObject> Spawners;
    [SerializeField]
    GameObject QuestionAnimal,Win,Lose;
    int AleatoryAnimal,AleatorySpawner,score;
   
    void Start()
    {    
        AleatoryAnimal = Random.Range(0,4);
        AleatorySpawner = Random.Range(0,4);
        Instantiate(Animals[AleatoryAnimal],Spawners[AleatorySpawner].transform);
        Instantiate(AnimalsInstantiate[AleatoryAnimal],QuestionAnimal.transform);
        Win.SetActive(false);
        Lose.SetActive(false);
        
    }
    void Update(){
      score = PlayerPrefs.GetInt("CheckScore");
        
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
