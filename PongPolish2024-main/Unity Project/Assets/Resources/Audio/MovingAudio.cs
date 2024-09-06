using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAudio : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject Ball;
    private AudioSource audioSource;
    private AudioSource audioSource2;
    private Rigidbody2D ballRigidbody;

    void Start()
    {
        Ball = FindFirstObjectByType<GameObject>();
        ballRigidbody = Ball.GetComponent<Rigidbody2D>();

        AudioClip audioClip = Resources.Load<AudioClip>("Audio/StoneSlide");
        AudioClip audioClip2 = Resources.Load<AudioClip>("Audio/Ding");

        if (audioClip != null)
        {

            GameObject audioObject = new GameObject("AudioSource");
            audioSource = audioObject.AddComponent<AudioSource>();
            audioSource2 = audioObject.AddComponent<AudioSource>();


            audioSource.clip = audioClip;
            audioSource2.clip = audioClip2;


            audioSource.loop = true;
            audioSource2.loop = true;
        }
        else
        {
            Debug.LogError("Audio clip not found in Resources/Audio/StoneSlide");
        }
    }


    void Update()
    {
        if (ballRigidbody != null && ballRigidbody.velocity.magnitude < 0.1f)
        {

            audioSource2.Play();




        }


        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {

            if (!audioSource.isPlaying)
            {
                audioSource.Play();

            }
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }


        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {

            audioSource.Stop();
        }
    }
}


