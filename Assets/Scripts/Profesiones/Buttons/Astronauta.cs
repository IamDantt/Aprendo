using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronauta : MonoBehaviour
{   
    GameObject Astro;
    public GameObject WinJ;
   


    void start(){
        Astro = GameObject.FindWithTag("Astronauta");
       
       
    }
    public void Check(){

        if(Astro  ??false){
            Debug.Log("Ganaste");
            PlayerPrefs.SetInt("CheckScore",1);
          
            
        }
        else{
           
             Debug.Log("Perdiste");
             PlayerPrefs.SetInt("CheckScore",2);
            
         
        }
       

    }
}
