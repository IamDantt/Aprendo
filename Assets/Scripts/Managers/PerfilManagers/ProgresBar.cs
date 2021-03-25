using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgresBar : MonoBehaviour
{
    [Header("bar")]
    public Image Barra;
    public int maximun, current;

    public GameObject LSombras, LFace, LProfesiones, LRompecabeza, LTesoro, LMenGame;

    public int puntos = 0;

    // Start is called before the first frame update
    void Start()
    {
        //current = PlayerPrefs.GetInt("PuntajeLogros");
    }

    public void sumarPuntos()
    {
        current = current + 10;
    }

    void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maximun;
        Barra.fillAmount = fillAmount;
    }

    void Update()
    {
        GetCurrentFill();      
    }

    public void Sumarpts()
    {
        
        if (GameMaster.GSombras == true)
        {
            puntos = puntos + 17;
            LSombras.SetActive(true);
            
        }
        if (Gestor.GProfesiones == true)
        {
            puntos = puntos + 17;
            LProfesiones.SetActive(true);
            

        }
        if (GameControl.GRompeCabezas == true)
        {
            puntos = puntos + 17;
            LRompecabeza.SetActive(true);
            
        }
        if (Manager.GHFaceParts == true || ManagerGirl.GMFacePart == true)
        {
            puntos = puntos + 17;
            
            LFace.SetActive(true);
            
        }
        if (BttnAnimal.GTesoro == true)
        {
            puntos = puntos + 17;

            LTesoro.SetActive(true);
        }
        if (SceneController.MenGame == true)
        {
            puntos = puntos + 17;

            LMenGame.SetActive(true);
        }



        current = puntos;

        PlayerPrefs.SetInt("PuntajeLogros", current);

    }

    
    public void GuardarPts()
    {

        
    }
}
