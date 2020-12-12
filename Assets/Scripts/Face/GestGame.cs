using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestGame : MonoBehaviour
{
    public GameObject GameBoy, GameGirl,PanelStart;
    void Start()
    {
        PanelStart.SetActive(true);
        GameBoy.SetActive(false);
        GameGirl.SetActive(false);       
    }

    public void Boy(){
        PanelStart.SetActive(false);
        GameBoy.SetActive(true);
        GameGirl.SetActive(false);   

    }

     public void Girl(){
        PanelStart.SetActive(false);
        GameBoy.SetActive(false);
        GameGirl.SetActive(true);   

    }

    
}
