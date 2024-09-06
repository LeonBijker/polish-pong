using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColission : MonoBehaviour
{
    CircleCollider2D ball;
    CameraShake camshake;
    // Start is called before the first frame update
    void Start()
    {
       ball = FindFirstObjectByType<CircleCollider2D>();
        camshake = FindFirstObjectByType<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        camshake.ShakeCamera(0.5f);
    }
}
