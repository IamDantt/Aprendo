using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigg2 : MonoBehaviour
{
    public int puntuacion2 = 0;
    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
       if (other.tag == "Animals")
        {
            puntuacion2 =1;
            Debug.Log (puntuacion2);
            
        }
    }
     void OnTriggerExit2D(Collider2D other){
       if (other.tag == "Animals")
        {
           puntuacion2 =0;
            Debug.Log (puntuacion2);
        }
    }
}
