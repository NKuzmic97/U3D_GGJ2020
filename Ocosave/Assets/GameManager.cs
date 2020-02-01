using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    [SerializeField] private GameObject[] lives;

    private int numberOfLives = 0;

    private void Awake()
    {
        numberOfLives = lives.Length;
    }

    public void LoseLife()
    {
        if(numberOfLives > 0) { 
            lives[numberOfLives-1].SetActive(false);
            numberOfLives--;
        }

        if(numberOfLives == 0)
        {
            SceneManager.LoadScene("game_over");

        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("game_over");
    }
}
