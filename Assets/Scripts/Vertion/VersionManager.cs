using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionManager : MonoBehaviour
{

    public Text Appvertion;

    // Start is called before the first frame update
    void Start()
    {
        Appvertion.text = "v" + " "+ Application.version.ToString();
    }
}
