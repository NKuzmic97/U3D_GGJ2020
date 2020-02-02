using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    [SerializeField] private GameObject[] lives;
    [SerializeField] private GameObject music;
    [SerializeField] private GameObject sounds;


    public static bool soundEnabled = true;
    public static bool musicEnabled = true;


    private int numberOfLives = 0;

    private void Update()
    {

    }

    private void Awake()
    {
        numberOfLives = lives.Length;

        if (musicEnabled)
        {
            music.SetActive(true);
        }
        else
        {
            music.SetActive(false);
        }

        if (soundEnabled)
        {
            sounds.SetActive(true);
        }
        else
        {
            sounds.SetActive(false);
        }
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
