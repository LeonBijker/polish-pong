using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHitSound : MonoBehaviour
{
    public AudioClip audioClip;
    private GameObject Ball;
    private AudioSource audioSource;

    void Start()
    {
        // Find the Ball GameObject
        Ball = GameObject.Find("Ball");

        audioSource = Ball.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = Ball.AddComponent<AudioSource>();
        }

        // Load the audio clip from Resources
        audioClip = Resources.Load<AudioClip>("Audio/ball_hit");
        if (audioClip == null)
        {
            Debug.LogError("AudioClip 'ball_hit' not found in Resources!");
        }
        else
        {
            audioSource.clip = audioClip;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Play audio when the ball collides
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("PlayerRight") || collision.gameObject.CompareTag("PlayerLeft") || collision.gameObject.CompareTag("BoundLeft") || collision.gameObject.CompareTag("BoundRight"))
        {
            audioSource.Play();
        }
    }
}
