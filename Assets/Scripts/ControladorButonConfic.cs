using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorButonConfic : MonoBehaviour
{
    public GameObject PanelConf;

    void Start()
    {
        //PanelConf.SetActive(false);
    }
    public void PAbrir()
    {
        PanelConf.SetActive(true);
    }

    public void PCerrar()
    {
        PanelConf.SetActive(false);
    }
}
