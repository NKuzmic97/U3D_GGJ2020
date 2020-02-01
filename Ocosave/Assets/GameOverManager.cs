﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {
    public void TryAgain()
    {
        SceneManager.LoadScene("main");        
    }
    public void Quit()
    {
        Application.Quit();
    }
}
