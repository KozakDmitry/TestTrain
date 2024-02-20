using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public TrainScript trainScript;

    public void OnPointerDown(PointerEventData eventData)
    {
        trainScript.StartEngine();
        StartCoroutine(CheckEngine());
    }


    IEnumerator CheckEngine()
    {
        yield return new WaitForSeconds(0.1f);
        trainScript.UpPower();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        StopCoroutine(CheckEngine());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
