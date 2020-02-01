using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private int score = 0;
    [SerializeField] private Text scoreText;

    public void AddScore()
    {
        score += 10;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
