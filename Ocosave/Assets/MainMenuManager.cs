using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuManager : MonoBehaviour {

    private float elapsedTime = 0.0f;
    [SerializeField] private GameObject intro = null;

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
    public void QuitGame()
    {
        Debug.Log("You have quitted the game!");
        Application.Quit();
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 4.0f)
        {
            intro.gameObject.SetActive(false);
        }
    }
}
