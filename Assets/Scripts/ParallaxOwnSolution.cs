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
    private float startPos, length,offset;
    private Transform startCamPosition;

    private int SpriteToMove = 0;

    void Start()
    {
        startPos = transform.position.x;
        Camera cam = Camera.main;
        startCamPosition = cam.transform;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        
    }

    void Update()
    {
        float distance = (cam.transform.position.x * parallaxEffect);

        foreach (GameObject t in backgrounds)
        {
            t.transform.position = new Vector3(t.transform.position.x + distance, transform.position.y, transform.position.z);
        }
       
        CheckIsChangeNeeded();
    }

    private void CheckIsChangeNeeded()
    {
        if(cam.transform.position.x- startCamPosition.position.x> length * parallaxEffect)
        {

        }
    }
}
