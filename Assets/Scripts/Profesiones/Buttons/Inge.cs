using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inge : MonoBehaviour
{
    GameObject IngeC;
    void Start()
    {
         IngeC = GameObject.FindWithTag("Ingenierio");  
    }

 public void Check(){

        if(IngeC  ??false){
              Debug.Log("Ganaste");
               PlayerPrefs.SetInt("CheckScore",1);
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Win);

        }
        else{
           
             Debug.Log("Perdiste");
              PlayerPrefs.SetInt("CheckScore",2);
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Error);
        }
       

    }
}
