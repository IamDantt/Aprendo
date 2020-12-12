using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigg3 : MonoBehaviour
{
    public int puntuacion3 = 0;
    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
       if (other.tag == "Animals")
        {
            puntuacion3 =1;
            Debug.Log (puntuacion3);
            
        }
    }
     void OnTriggerExit2D(Collider2D other){
       if (other.tag == "Animals")
        {
           puntuacion3 =0;
            Debug.Log (puntuacion3);
        }
    }
}
