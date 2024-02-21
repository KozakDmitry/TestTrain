using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public TrainScript trainScript;
    public float increaseTiming = 0.05f;
    private bool isPowerRising = false;
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        trainScript.StartEngine();
        isPowerRising = true; 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPowerRising = false;
    }

    void Update()
    {
      if(isPowerRising) 
        {
            trainScript.UpPower();
        }
        
    }
}
