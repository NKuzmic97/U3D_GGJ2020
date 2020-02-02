using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuManager : MonoBehaviour {

    private float elapsedTime = 0.0f;
    static private bool firstTimeIntro = false;
    [SerializeField] private GameObject intro = null;
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

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
        Debug.Log("You have quitted the game!");
        Application.Quit();
    }

    public void OptionsMenu()
    {
        Debug.Log("You have clicked the Settings menu!");
        SceneManager.LoadScene("options_menu");
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 4.0f || firstTimeIntro)
        {
            intro.gameObject.SetActive(false);
            firstTimeIntro = true;
        }
    }
}
