using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstPro : MonoBehaviour
{
    public GameObject PanelText;
    public GameObject[] TextProf;
     int item;
    void Start()
    {  
         item = Random.Range(0,1);
        Instantiate (TextProf[item],PanelText.transform);
    }

    
    void Update()
    {
        
    }
}
