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
        ShakeCamera(1);
    }

    public void ShakeCamera(float duration)
    {
        print("in camshake");
        float sensitivity = 0.5f;
        Vector3 cameraOriginalPosition = cam.transform.position;
        cam.transform.position = cameraOriginalPosition;
        Vector3 cameraNewPosition;
        duration -= Time.deltaTime;
        if (duration >= 0)
        {
            cameraNewPosition = cameraOriginalPosition + new Vector3(Random.Range(-sensitivity, sensitivity), Random.Range(-sensitivity, sensitivity), 0);
            cam.transform.position = cameraNewPosition;
        }
    }
}
