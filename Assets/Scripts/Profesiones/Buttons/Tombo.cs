﻿using System.Collections;
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
            
        }
        else{
           
             Debug.Log("Perdiste");
              PlayerPrefs.SetInt("CheckScore",2);
        }
       

    }
}
