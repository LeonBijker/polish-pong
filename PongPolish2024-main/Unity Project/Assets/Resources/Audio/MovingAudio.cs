using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAudio : MonoBehaviour
{
    // Start is called before the first frame update


    private AudioSource audioSource;

    void Start()
    {
        // Load the audio clip from the Resources folder
        AudioClip audioClip = Resources.Load<AudioClip>("Audio/StoneSlide");

        if (audioClip != null)
        {
            // Create a new GameObject to hold the AudioSource
            GameObject audioObject = new GameObject("AudioSource");
            audioSource = audioObject.AddComponent<AudioSource>();

            // Assign the AudioClip to the AudioSource
            audioSource.clip = audioClip;

            // Enable looping
            audioSource.loop = true;
        }
        else
        {
            Debug.LogError("Audio clip not found in Resources/Audio/StoneSlide");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Play the audio if it's not already playing
            if (!audioSource.isPlaying)
            {
                audioSource.Play();

            }
        }
        // Check if the W or S keys are pressed
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            // Play the audio if it's not already playing
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        // Optionally, stop the audio when the W or S keys are released
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {

            audioSource.Stop();
        }
    }
}


