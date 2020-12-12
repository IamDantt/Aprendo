using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conejo : MonoBehaviour
{
    public GameObject AnimalBlack;
     Vector2 AnimalInitialPos;
     int cont=0;
     public int contAnimal =0;
     
   
    void Start()
    {
       AnimalBlack = GameObject.FindWithTag("Conejo");  
    }

    void Drag(){
      gameObject.transform.position = Input.mousePosition;   
  
    }
    public void DragAnimal(){
      if(cont!=1){
         AnimalInitialPos = gameObject.transform.position; 
         cont=1;
        }
          Drag();
   }
   

   public void DropAnimal(){
       float Distance= Vector3.Distance(gameObject.transform.position, AnimalBlack.transform.position);
       if (Distance<70){
           gameObject.transform.position = AnimalBlack.transform.position;
            contAnimal=1;
           
       }    
       else{
           gameObject.transform.position = AnimalInitialPos;
            contAnimal=0;
          
           
       }
   }
}
