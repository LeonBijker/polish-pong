using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapColorChanger : MonoBehaviour
{
    SpriteRenderer[] wallRenderers = FindObjectsOfType<SpriteRenderer>();
    private Camera cam;
    void Start()
    {
        cam = FindFirstObjectByType<Camera>();
    }
    
    private void OnCollisionEnter2D(Collider2D collision)
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
