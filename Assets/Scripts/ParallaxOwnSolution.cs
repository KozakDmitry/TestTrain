using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ParallaxOwnSolution : MonoBehaviour
{
    public GameObject[] backgrounds;
    public float parallaxEffect;
    private Camera cam;
    private float startPos, length;
    float distance;
    private int SpriteToMove = 0;

    void Start()
    {
        startPos = transform.position.x;
        cam = Camera.main;
        length = backgrounds[0].GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        distance = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
        CheckIsChangeNeeded();
    }

    private void CheckIsChangeNeeded()
    {
        if (cam.transform.position.x > backgrounds[(SpriteToMove + 1) % 3].transform.position.x+4)
        {
            backgrounds[SpriteToMove].transform.position = new Vector3(backgrounds[(SpriteToMove + 2) % 3].transform.position.x + length,
                                                                       backgrounds[SpriteToMove].transform.position.y,
                                                                       backgrounds[SpriteToMove].transform.position.z);
            SpriteToMove = ++SpriteToMove % 3;
        }
    }
}
