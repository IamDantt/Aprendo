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
            
        }
        else{
           
             Debug.Log("Perdiste");
              PlayerPrefs.SetInt("CheckScore",2);
        }
       

    }
}
