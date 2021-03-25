using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodestruir : MonoBehaviour
{
    
    public static Nodestruir Config;
    
    private void Awake()
    {
        if (Config != null && Config != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Config = this;
        DontDestroyOnLoad(this);

    } 
}
