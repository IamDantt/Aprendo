using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{    

    public int puntuacion;
    Conejo conejo;  

    void Start(){
        conejo = gameObject.GetComponent<Conejo>();
        
    }
    
 
    void Update()
    {
        puntuacion = conejo.contAnimal;
        Debug.Log(puntuacion);
    }
}
