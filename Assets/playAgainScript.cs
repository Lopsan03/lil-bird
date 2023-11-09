using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAgainScript : MonoBehaviour
{
    public AudioSource gameOverAudioSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGameOverSound()
    {
        // Play the game over audio using the gameOverAudioSource
        gameOverAudioSource.Play();
    }
}
