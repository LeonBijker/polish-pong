using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColission : MonoBehaviour
{
    GameObject ball;
    CameraShake camshake;
    // Start is called before the first frame update
    void Start()
    {
        ball = FindFirstObjectByType<BallMovement>().gameObject;
        ball.AddComponent<CameraShake>();
        camshake = FindFirstObjectByType<CameraShake>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
