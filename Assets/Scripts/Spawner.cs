using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    [Header("Timers")]
    public float maxTime;
    public float timer;

    [Header("Spawnable Objects")]
    public GameObject[] obstacles = new GameObject[0]; 

    void Start()
    {
        GameObject newObstacle = Instantiate(obstacles[0]);
        newObstacle.transform.position = transform.position + new Vector3(0, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            int rnd = Random.Range(0, (obstacles.Length));
            GameObject newObstacle;
            newObstacle = Instantiate(obstacles[rnd]);
            newObstacle.transform.position = transform.position;
            Destroy(newObstacle, 10f);
            //maxTime -= maxTime * 0.01f
            timer = 0;
        }
        timer += Time.deltaTime;
        
    }
}
