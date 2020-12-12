using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigg4 : MonoBehaviour
{
    public int puntuacion4 = 0;
    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
       if (other.tag == "Animals")
        {
            puntuacion4 =1;
            Debug.Log (puntuacion4);
            
        }
    }
     void OnTriggerExit2D(Collider2D other){
       if (other.tag == "Animals")
        {
           puntuacion4 =0;
            Debug.Log (puntuacion4);
        }
    }
}
