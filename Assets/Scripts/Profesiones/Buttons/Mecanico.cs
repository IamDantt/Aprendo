using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanico : MonoBehaviour
{
    GameObject Mec;
    void Start()
    {
        Mec = GameObject.FindWithTag("Mecanico"); 
    }

    public void Check(){

        if(Mec  ??false){
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
