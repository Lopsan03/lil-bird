using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource audioSource;
    private bool hasCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }

        if (transform.position.y > 17 || transform.position.y < -17)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided && birdIsAlive)
        {
            hasCollided = true; // Set the flag to true to prevent repeated audio playback
            logic.gameOver();
            birdIsAlive = false;
            audioSource.Play();
        }
    }
}
