using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapColorChanger : MonoBehaviour
{
    SpriteRenderer[] wallRenderers;
    private Camera cam;
    void Start()
    {
        wallRenderers = FindObjectsOfType<SpriteRenderer>();
        cam = FindFirstObjectByType<Camera>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int randNumber = Random.Range(1, 5);
        if (randNumber == 1)
        {
            foreach (var renderer in wallRenderers)
            {
                renderer.color = Color.blue;
            }
        }
        else if (randNumber == 2)
        {
            foreach (var renderer in wallRenderers)
            {
                renderer.color = Color.red;
            }
        }
        else if (randNumber == 3)
        {
            foreach (var renderer in wallRenderers)
            {
                renderer.color = Color.green;
            }
        }
        else if (randNumber == 4)
        {
            foreach (var renderer in wallRenderers)
            {
                renderer.color = Color.yellow;
            }
        }
    }
}
