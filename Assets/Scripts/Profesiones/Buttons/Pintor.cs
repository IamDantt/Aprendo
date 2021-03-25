using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintor : MonoBehaviour
{
    GameObject Pint;
    void Start()
    {
        Pint= GameObject.FindWithTag("Pintor");    
    }

   public void Check(){

        if(Pint  ??false){
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
