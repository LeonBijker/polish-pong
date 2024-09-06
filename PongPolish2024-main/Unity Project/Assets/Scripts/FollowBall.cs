using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinemachine : MonoBehaviour
{
    Camera Camera;
    GameObject Ball;
    Vector3 offset = new Vector3 (0,0,-10);
    // Start is called before the first frame update
    void Start()
    {
        Camera = FindFirstObjectByType<Camera>();
        Ball = FindFirstObjectByType<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera != null && Ball != null)
        {
            Camera.transform.position = Ball.transform.position + offset;
        }
    }
   
}
