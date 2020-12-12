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
            
        }
        else{
           
             Debug.Log("Perdiste");
              PlayerPrefs.SetInt("CheckScore",2);
        }
       

    }
}
