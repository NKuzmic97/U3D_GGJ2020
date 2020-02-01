using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] private GameObject[] lives;
    private int numberOfLives = 0;

    private void Start()
    {
        numberOfLives = lives.Length;
    }

    void Update() {
        if (numberOfLives < 0)
        {
            //game over
        }


    }

    public void LoseLife()
    {
        if(numberOfLives > 0) { 
            lives[numberOfLives-1].SetActive(false);
            numberOfLives--;
        }
    }
}
