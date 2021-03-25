using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private Transform[] picture;
    

    [SerializeField]
    private GameObject Win;

    public GameObject Wait;

    public static bool youWin;

    public static bool GRompeCabezas;

    // Start is called before the first frame update
    void Start()
    {
        Win.SetActive(false);
        youWin = false;
        Wait.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (picture[0].rotation.z == 0 &&
            picture[1].rotation.z == 0 &&
            picture[2].rotation.z == 0 &&
            picture[3].rotation.z == 0 &&
            picture[4].rotation.z == 0 &&
            picture[5].rotation.z == 0)
        {
            youWin = true;            
        }
    }

    public void CheckConfirm()
    {
        if (youWin == true)
        {
            Win.SetActive(true);
            GRompeCabezas = true;
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Win);
        }
        else
        {
            Wait.SetActive(true);
            SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Error);
        }
        
    }
}
