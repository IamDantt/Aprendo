using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oso : MonoBehaviour
{   
     public GameObject OsoBlack;
     Vector2 OsoInitialPos;
     int cont=0;
    void Start()
    {
         
        OsoBlack = GameObject.FindWithTag("Oso");
    }

    void Drag(){
      gameObject.transform.position = Input.mousePosition;   
    }
    public void DragAnimal(){
         if(cont!=1){
         OsoInitialPos = gameObject.transform.position; 
         cont=1;
      }
          Drag();
   }
   public void DropAnimal(){
       float Distance= Vector3.Distance(gameObject.transform.position, OsoBlack.transform.position);
       if (Distance<70){
           gameObject.transform.position = OsoBlack.transform.position;
       }
       else{
           gameObject.transform.position = OsoInitialPos;          
       }
   }
}
