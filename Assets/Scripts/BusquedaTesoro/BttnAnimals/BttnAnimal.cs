using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BttnAnimal : MonoBehaviour
{
    GameObject Animal;

    public static bool GTesoro = false;
 
    public void SearchAnimal(string nameAnimal) {

        Animal = GameObject.FindWithTag(nameAnimal);
    }
     public void CheckQuest() {

        if (Animal??false){
             PlayerPrefs.SetInt("CheckScore",1);
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Win);
            GTesoro = true;
            Debug.Log("Ganaste");  
        }
        else{
             PlayerPrefs.SetInt("CheckScore",2);   
              Debug.Log("Perdiste");
        }
    }
}
