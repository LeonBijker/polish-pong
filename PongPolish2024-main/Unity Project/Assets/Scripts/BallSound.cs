using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class BallSound : MonoBehaviour
{
    public GameObject Ball;

    void Start()
    {
        Ball = GameObject.Find("Ball");

        if (Ball != null)
        {
            if (Ball.GetComponent<BallHitSound>() == null)
            {
                Ball.AddComponent<BallHitSound>();
            }
        }
        else
        {
            Debug.LogError("Ball GameObject is not assigned.");
        }
    }
}
