using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public TrainScript trainScript;
    public float increaseTiming = 0.05f;
    private bool isPowerRising = false, isPowerDecreasing = false;


    public void OnPointerDown(PointerEventData eventData)
    {
        trainScript.StartEngine();
        isPowerRising = true;
        isPowerDecreasing = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPowerRising = false;
        isPowerDecreasing = true;
    }

    void FixedUpdate()
    {
        if (isPowerRising)
        {
            trainScript.UpPower();
        }
        else if (isPowerDecreasing)
        {
            trainScript.DecreasePower();
        }
    }
}
