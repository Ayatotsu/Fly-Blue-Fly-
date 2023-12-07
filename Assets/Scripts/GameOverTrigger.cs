using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    [Header("Class Reference")]
    public GameManager gameManager;

    [Header("Panels")]
    public GameObject objCanvas;
    public GameObject inGamePanel;
    public GameObject gameOverPanel;

    [Header("GameElements")]
    public GameObject gameElements;
    public GameObject mc;
    public GameObject spawner;

    [Header("AudioElements")]
    public GameObject audioHitObject;
    public AudioSource audioHit;
    public GameObject audioChompObject;
    public AudioSource audioChomp;
    

    [Header("Obstacle Type")]
    public bool isEnemy; //this is always true and it is an obstacle attached to enemies
    


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        objCanvas = GameObject.Find("Canvas").gameObject;
        inGamePanel = objCanvas.transform.Find("PanelInGame").gameObject;
        gameOverPanel = objCanvas.transform.Find("PanelGameOver").gameObject;

        gameElements = GameObject.Find("GameElements").gameObject;
        mc = gameElements.transform.Find("MainCharacter").gameObject;
        spawner = gameElements.transform.Find("Spawner").gameObject;

        audioHit = GameObject.Find("HitSound").GetComponent<AudioSource>();
        audioChomp = GameObject.Find("ChompSound").GetComponent<AudioSource>();
        
    }

    private void OnCollisionEnter2D(Collision2D actor)
    {
        inGamePanel.gameObject.SetActive(false);
        gameOverPanel.gameObject.SetActive(true);
        mc.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);

        if (isEnemy)
        {
            audioChomp.Play();
        }
        else 
        {
            audioHit.Play();
        }

        if (gameManager.totalScore > gameManager.highScore)
        {
            PlayerPrefs.SetInt("p_highScore", gameManager.totalScore);
            PlayerPrefs.Save();
        }
    }
}
