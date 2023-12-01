using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Initial Value")]
    public int totalScore;
    public int highScore;

    [Header("InGame panel")]
    public Text txtScore;

    [Header("GameOver panel")]
    public Text txtLastScore;
    public Text txtHIghScore;


    void Update()
    {
        highScore = PlayerPrefs.GetInt("p_highScore");

        txtScore.text = totalScore.ToString();
        txtHIghScore.text = highScore.ToString();
    }
}
