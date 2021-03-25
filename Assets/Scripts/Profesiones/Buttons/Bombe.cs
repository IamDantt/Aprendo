using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe : MonoBehaviour

{
    GameObject Bombero;
    void Start()

    {
      Bombero = GameObject.FindWithTag("Bombero");    
    }

    public void Check(){

        if(Bombero  ??false){
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
