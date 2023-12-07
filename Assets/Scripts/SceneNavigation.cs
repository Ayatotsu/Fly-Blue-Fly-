using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneNavigation : MonoBehaviour
{
    [Header("Class REference")]
    public GameManager gameManager;

    [Header("Game Object Reference")]
    public GameObject mc;
    public GameObject spawner;

    [Header("Panel Reference")]
    public GameObject currentPanel;
    public GameObject nextPanel;


    public void BtnStart()
    {
        currentPanel.gameObject.SetActive(false);
        nextPanel.gameObject.SetActive(true);
        mc.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);

        gameManager.totalScore = 0;

        mc.transform.position = new Vector3(0, 0, 0);
    }

    public void BtnShowStory()
    {
        currentPanel.gameObject.SetActive(false);
        nextPanel.gameObject.SetActive(true);

    }

    public void BtnQuit()
    {
        Application.Quit();
    }

}
