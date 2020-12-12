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
            
        }
        else{
           
             Debug.Log("Perdiste");
              PlayerPrefs.SetInt("CheckScore",2);
        }
       

    }
}
