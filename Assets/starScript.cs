using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class starScript : MonoBehaviour
{
    private AudioSource buttonAudio;

    private void Start()
    {
        // Get the AudioSource component from the button
        buttonAudio = GetComponent<AudioSource>();
    }

    public void PlayButtonClickSound()
    {
        // Check if an AudioSource is attached and play the sound
        if (buttonAudio != null)
        {
            buttonAudio.Play();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
