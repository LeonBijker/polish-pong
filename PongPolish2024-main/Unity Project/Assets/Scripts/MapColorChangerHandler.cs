using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapColorChangerHandler : MonoBehaviour
{
    GameObject ball;

    void Start()
    {
        ball = FindFirstObjectByType<BallMovement>().gameObject;
        ball.AddComponent<MapColorChanger>();
    }
}
