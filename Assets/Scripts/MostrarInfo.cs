using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarInfo : MonoBehaviour
{

    public GameObject txt1, txt2, txt3, txt4, txt5, txt6;

    public bool Info = false;

    // Start is called before the first frame update
    void Start()
    {
        OffInfo();

    }

    public void OffInfo()
    {
        txt1.SetActive(false);
        txt2.SetActive(false);
        txt3.SetActive(false);
        txt4.SetActive(false);
        txt5.SetActive(false);
        txt6.SetActive(false);
    }

    public void ShowInfo()
    {
        Info = true;
        txt1.SetActive(true);
        txt2.SetActive(true);
        txt3.SetActive(true);
        txt4.SetActive(true);
        txt5.SetActive(true);
        txt6.SetActive(true);
        
        StartCoroutine(OcultarInfo());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    
    IEnumerator OcultarInfo()
    {
        yield return new WaitForSeconds(5);
        if (Info == true)
        {
            txt1.SetActive(false);
            txt2.SetActive(false);
            txt3.SetActive(false);
            txt4.SetActive(false);
            txt5.SetActive(false);
            txt6.SetActive(false);
            Info = false;
        }
        
    }

}
