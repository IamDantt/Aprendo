﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chef : MonoBehaviour
{
    GameObject ChefC;
    void Start()

    {
      ChefC = GameObject.FindWithTag("Chef");    
    }

    
    public void Check(){

        if(ChefC  ??false){
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
