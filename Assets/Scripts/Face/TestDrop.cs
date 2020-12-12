using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrop : MonoBehaviour
{
     public GameObject AnimalBlack;
     Vector2 AnimalInitialPos;
     
     
   
    void Start()
    {
           AnimalInitialPos = gameObject.transform.position;  
    }

   
        

    public void DragAnimal(){
   
          gameObject.transform.position = Input.mousePosition; 
   }
   

   public void DropAnimal(){
       float Distance= Vector3.Distance(gameObject.transform.position, AnimalBlack.transform.position);
       if (Distance<70){
           gameObject.transform.position = AnimalBlack.transform.position;
            
           
       }    
       else{
           gameObject.transform.position = AnimalInitialPos;
          
          
           
       }
   }
}
