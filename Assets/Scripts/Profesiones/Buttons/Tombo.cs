using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tombo : MonoBehaviour
{
    GameObject Tomb;

    void Start()
    {
        Tomb = GameObject.FindWithTag("Tombo");    
    }

   public void Check(){

        if(Tomb  ??false){
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
