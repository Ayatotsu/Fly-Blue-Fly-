using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    [Header("Class Reference")]
    public GameManager gameManager;

    [Header("AudioElements")]
    public GameObject autioScoreObject;
    public AudioSource audioScore;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioScore = GameObject.Find("PointSound").GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D actor)
    {
        if (actor.gameObject.CompareTag("Player"))
        {
            audioScore.Play();
            gameManager.totalScore += 1;
        }
    }

}
