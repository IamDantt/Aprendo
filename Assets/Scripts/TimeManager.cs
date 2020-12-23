using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 5;
    public Text UIText;
    public GameObject Win, Lose, PComenzar;

    //public bool loseGame = false;
    void Start()
    {
        Win.SetActive(false);
        Lose.SetActive(false);
        PComenzar.SetActive(true);

        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        UIText.text = time.ToString("f0");

        PauseGame();
        
    }

    public void PauseGame()
    {
        if (time <= 0)
        {
            Time.timeScale = 0;
            
        }
    }

    IEnumerator Espearar()
    {
        yield return new WaitForSeconds(time);
        GameLost();
    }
    public void GameLost()
    {
        Lose.SetActive(true);
        //loseGame = true;
    }

    public void Comenzar()
    {
        //loseGame = false;
        Time.timeScale = 1;
        time = time;
        StartCoroutine(Espearar());
        PComenzar.SetActive(false);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Play);
    }

}
