using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectOptions : MonoBehaviour
{
    public static bool Interactible = false;
    public Button[] nivelBTN;
    public int nivel;

    public int VariableI = 1;

    public GameObject[] Logros;

    public GameObject Buno, Bdos, Btres, Bcuatro;


    void Start()
    {
        //GuardadoConExito.SetActive(false);
        //Guardando.SetActive(false);
        cargarDatos();
        for (int i = VariableI; i < nivelBTN.Length; i++)
        {

            if (i + 2 > nivel)                
                nivelBTN[i].interactable = false;


            if (GameMaster.GSombras == true)
            {
                nivelBTN[1].interactable = true;
                Buno.SetActive(false);
            }
            if (BttnAnimal.GTesoro == true)
            {
                nivelBTN[2].interactable = true;
                Bdos.SetActive(false);
            }
            if (Gestor.GProfesiones == true)
            {
                nivelBTN[3].interactable = true;
                Btres.SetActive(false);
            }
            if (Manager.GHFaceParts == true || ManagerGirl.GMFacePart == true)
            {
                nivelBTN[4].interactable = true;
                Bcuatro.SetActive(false);
            }
            if (GameControl.GRompeCabezas == true)
            {
                nivelBTN[5].interactable = true;
                
            }
            

        }
         
         nivelBTN[0].interactable = true;

       
    }
    private void Update()
    {
        if (Interactible == true)
        {
            VariableI += 1;
            Interactible = false;
        }
        
        

    }

    public void cargarDatos()
    {
        VariableI = PlayerPrefs.GetInt("DatoSave");

    }

    public void guardarDatos()
    {
        
        PlayerPrefs.SetInt("DatoSave", VariableI);        
        PlayerPrefs.Save();
        
        StartCoroutine(TiempoForFalse());
    }

    IEnumerator TiempoForFalse()
    {
        //Guardando.SetActive(true);
        yield return new WaitForSeconds(2);
        //Guardando.SetActive(false);
        //GuardadoConExito.SetActive(true);
        yield return new WaitForSeconds(2);
        //GuardadoConExito.SetActive(false);
    }

}
