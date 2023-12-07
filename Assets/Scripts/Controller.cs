using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float velocity;
    public Rigidbody2D rb;
    public AudioSource audioFlap;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        audioFlap = GameObject.Find("FlappingSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;
        }
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            audioFlap.Play();
        }
    }
}
