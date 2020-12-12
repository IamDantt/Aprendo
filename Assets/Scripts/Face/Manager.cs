using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Hair,Nose,CejaLeft,CejaRight,EyeLeft,EyeRigh,OrejaR,OrejaI,Mouth;

    public GameObject HairB,NoseB,CejaLeftB,CejaRightB,EyeLeftB,EyeRighB,OrejaRB,OrejaIB,MouthB;

    public GameObject Win, Lose;

    Vector2 HairInitialPos, NoseInitialPos, CejaLeftInitialPos, CejaRightInitialPos, EyeLeftInitialPos, EyeRightInitialPos, OrejaRInitialPos,
    OrejaIInitialPos, MouthInitialPos;

    int cont=0,cont1=0,cont2=0,cont3=0,cont4=0,cont5=0,cont6=0,cont7=0,cont8=0;

     int Score;

    void Start()
    {

      Win.SetActive(false);
      Lose.SetActive(false);


        HairInitialPos = Hair.transform.position; 
        NoseInitialPos = Nose.transform.position; 
        CejaLeftInitialPos = CejaLeft.transform.position; 
        CejaRightInitialPos = CejaRight.transform.position; 
        EyeLeftInitialPos = EyeLeft.transform.position; 
        EyeRightInitialPos = EyeRigh.transform.position; 
        OrejaRInitialPos = OrejaR.transform.position; 
        OrejaIInitialPos = OrejaI.transform.position; 
        MouthInitialPos =   Mouth.transform.position;   


    }

    void Update(){

      Score= cont + cont1 + cont2 + cont3 + cont4 + cont5 + cont6 + cont7 + cont8;
    
    }

    public void DragHair(){
      Hair.transform.position = Input.mousePosition;   
    }
    
    public void DragNose(){
      Nose.transform.position = Input.mousePosition;   
    }

    public void DragCejaLeft(){
      CejaLeft.transform.position = Input.mousePosition;   
    }

    public void DragCejaRight(){
      CejaRight.transform.position = Input.mousePosition;   
    }

    public void DragEyeLeft(){
      EyeLeft.transform.position = Input.mousePosition;   
    }

    public void DragEyeRigh(){
      EyeRigh.transform.position = Input.mousePosition;   
    }

    public void DragOrejaR(){
      OrejaR.transform.position = Input.mousePosition;   
    }

    public void DragOrejaI(){
      OrejaI.transform.position = Input.mousePosition;   
    }

    public void DragMouth(){
      Mouth.transform.position = Input.mousePosition;   
    }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void DropHair(){
        float Distance= Vector3.Distance(Hair.transform.position, HairB.transform.position);
       if (Distance<70){
           Hair.transform.position = HairB.transform.position;
           cont=1;
       }
        else{
           Hair.transform.position = HairInitialPos; 
           cont=0;    
       }
    }

     public void DropNose(){
        float Distance= Vector3.Distance(Nose.transform.position, NoseB.transform.position);
       if (Distance<70){
           Nose.transform.position = NoseB.transform.position;
            cont1=1;
       }
        else{
           Nose.transform.position = NoseInitialPos; 
            cont1=0;   
       }
    }

     public void DropCejaLeft(){
        float Distance= Vector3.Distance(CejaLeft.transform.position, CejaLeftB.transform.position);
       if (Distance<70){
           CejaLeft.transform.position = CejaLeftB.transform.position;
            cont2=1;
       }
        else{
           CejaLeft.transform.position = CejaLeftInitialPos;      
           cont2=0;
       }
    }

    public void DropCejaRight(){
        float Distance= Vector3.Distance(CejaRight.transform.position, CejaRightB.transform.position);
       if (Distance<70){
           CejaRight.transform.position = CejaRightB.transform.position;
            cont3=1;
       }
        else{
           CejaRight.transform.position =CejaRightInitialPos;      
           cont3=0;
       }
    }

    public void DropEyeLeft(){
        float Distance= Vector3.Distance(EyeLeft.transform.position, EyeLeftB.transform.position);
       if (Distance<70){
           EyeLeft.transform.position = EyeLeftB.transform.position;
            cont4=1;
       }
        else{
           EyeLeft.transform.position =EyeLeftInitialPos; 
           cont4=0;     
       }
    }

    public void DroEyeRigh(){
        float Distance= Vector3.Distance(EyeRigh.transform.position, EyeRighB.transform.position);
       if (Distance<70){
           EyeRigh.transform.position = EyeRighB.transform.position;
            cont5=1;
       }
        else{
           EyeRigh.transform.position =EyeRightInitialPos; 
           cont5=0;     
           
       }
    }

    public void DropMouth(){
        float Distance= Vector3.Distance(Mouth.transform.position, MouthB.transform.position);
       if (Distance<70){
           Mouth.transform.position = MouthB.transform.position;
           cont6=1;
       }
        else{
           Mouth.transform.position =MouthInitialPos; 
           cont6=0;
             
       }
    }

    public void DropOrejaR(){
        float Distance= Vector3.Distance(OrejaR.transform.position, OrejaRB.transform.position);
       if (Distance<70){
           OrejaR.transform.position = OrejaRB.transform.position;
            cont7=1;
       }
        else{
          OrejaR.transform.position =OrejaRInitialPos;    
          cont7=0;
          
       }
    }

    public void DropOrejaI(){
        float Distance= Vector3.Distance(OrejaI.transform.position, OrejaIB.transform.position);
       if (Distance<70){
           OrejaI.transform.position = OrejaIB.transform.position;
            cont8=1;
       }
        else{
          OrejaI.transform.position =OrejaIInitialPos;  
          cont8=0;         
       }
    }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public void BttnCheck(){
  if(Score==9){

       Win.SetActive(true);
       Lose.SetActive(false);
    
  }
  else{
    Win.SetActive(false);
    Lose.SetActive(true);
     StartCoroutine("Wait");
   }

  }

    IEnumerator Wait(){
       yield return new WaitForSeconds(4);
       Lose.SetActive(false);
       
    }
}
