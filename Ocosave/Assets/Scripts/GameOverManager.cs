using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {
    [SerializeField] private GameObject loop = null;

    private void Awake()
    {
        if (GameManager.musicEnabled)
        {
            loop.SetActive(true);
        }
        else
        {
            loop.SetActive(false);
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("main");        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("main_menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
