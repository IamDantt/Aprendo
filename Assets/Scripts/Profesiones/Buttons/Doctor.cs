using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : MonoBehaviour
{
    GameObject Doc;
    void Start()
    {
      Doc = GameObject.FindWithTag("Doctor");     
    }

    public void Check(){

        if(Doc  ??false){
              Debug.Log("Ganaste");
               PlayerPrefs.SetInt("CheckScore",1);
            
        }
        else{
           
             Debug.Log("Perdiste");
              PlayerPrefs.SetInt("CheckScore",2);
              
        }
       

    }
}
