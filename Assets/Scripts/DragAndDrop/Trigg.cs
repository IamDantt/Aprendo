using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigg : MonoBehaviour
{
    public int puntuacion = 0;
    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
       if (other.tag == "Animals")
        {
            puntuacion =1;
            Debug.Log (puntuacion);
            
        }
    }
     void OnTriggerExit2D(Collider2D other){
       if (other.tag == "Animals")
        {
           puntuacion =0;
            Debug.Log (puntuacion);
        }
    }
}
