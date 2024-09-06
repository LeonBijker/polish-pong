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

    }

    public void ShakeCamera(float duration)
    {
        print("in camshake");
        float sensitivity = 0.5f;
        Vector3 cameraOriginalPosition = cam.transform.position;
        cam.transform.position = cameraOriginalPosition;
        Vector3 cameraNewPosition;
        StartCoroutine(shakingCam(duration));
    }

        IEnumerator shakingCam(float duration)
        {
        float sensitivity = 0.5f;
        Vector3 cameraOriginalPosition = cam.transform.position;
        cam.transform.position = cameraOriginalPosition;
        Vector3 cameraNewPosition;

        print("incoroutine");
            for (int i = 0; i < duration; i++)
            {
                cameraNewPosition = cameraOriginalPosition + new Vector3(Random.Range(-sensitivity, sensitivity), Random.Range(-sensitivity, sensitivity), 0);
                cam.transform.position = cameraNewPosition;
                yield return new WaitForSeconds(.02f);
            }
            cam.transform.position = cameraOriginalPosition;
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("oncollission");
        ShakeCamera(20f);
    }
}
