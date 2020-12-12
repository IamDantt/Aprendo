using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{   
     public GameObject DogBlack;
     Vector2 OsoInitialPos;
     int cont=0;
     public int contAnimal =0;
     
    void Start()
    {
        DogBlack = GameObject.FindWithTag("Dog");
    }
    void Drag(){
      gameObject.transform.position = Input.mousePosition;   
    }

    public void DragAnimal(){
      if(cont!=1){
         OsoInitialPos = gameObject.transform.position; 
         gameObject.transform.position = Input.mousePosition;
         cont=1;
      }
          Drag();
   }
   public void DropAnimal(){
       float Distance= Vector3.Distance(gameObject.transform.position, DogBlack.transform.position);
       if (Distance<70){
           gameObject.transform.position = DogBlack.transform.position;
           contAnimal =1;
       }    
       else{
           gameObject.transform.position = OsoInitialPos;
           contAnimal =0;
       }
   }
}
