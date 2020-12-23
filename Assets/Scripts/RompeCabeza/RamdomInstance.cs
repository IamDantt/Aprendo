using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomInstance : MonoBehaviour
{

    public GameObject[] ListPuzzle;

    // Start is called before the first frame update
    void Start()
    {
        SpawmRandonPuzzle();
    }

    public void SpawmRandonPuzzle()
    {
        int i = Random.Range(0, ListPuzzle.Length); // This creates a random number between 0 and the total number of enemies in the array (Make sure you have added enemies to the array in the inspector)
        ListPuzzle[i].SetActive(true); // Creates that random enemy
    }
}
