using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    UnityEngine.Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindFirstObjectByType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            ShakeCamera(1);
        }
    }

    void ShakeCamera(float duration)
    {
        print("in camshake");
        Vector3 cameraOriginalPosition = cam.transform.position;
        Vector3 cameraNewPosition;
        duration -= Time.deltaTime;
        if (duration >= 0)
        {
            cameraNewPosition = cameraOriginalPosition + new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
            cam.transform.position = cameraNewPosition;
        }
    }
}
