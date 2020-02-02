using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour {
    [SerializeField] private Button soundButton;
    [SerializeField] private Button musicButton;

    [SerializeField] private Image soundCheckmark;
    [SerializeField] private Image musicCheckmark;

    private void Update()
    {
        if (GameManager.soundEnabled)
        {
            soundCheckmark.gameObject.SetActive(true);
        }
        else
        {
            soundCheckmark.gameObject.SetActive(false);
        }

        if (GameManager.musicEnabled)
        {
            musicCheckmark.gameObject.SetActive(true);
        }
        else
        {
            musicCheckmark.gameObject.SetActive(false);
        }
    }

    public void SwitchMusicState()
    {
        if (GameManager.musicEnabled)
        {
            GameManager.musicEnabled = false;
        }
        else
        {
            GameManager.musicEnabled = true;
        }
    }

    public void SwitchSoundState()
    {
        if (GameManager.soundEnabled)
        {
            GameManager.soundEnabled = false;
        }
        else
        {
            GameManager.soundEnabled = true;
        }
    }

    public void BackButton()
    {
        SceneManager.LoadScene("main_menu");
    }

}
