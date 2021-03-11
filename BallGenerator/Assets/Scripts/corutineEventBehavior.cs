using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class corutineEventBehavior : MonoBehaviour
{

    public UnityEvent startEvent;
    public int number, maxNumber;
    public float holdTime = 1f;
    private WaitForSeconds wsfObj;
    
    IEnumerator Start()
    {
        wsfObj = new WaitForSeconds(holdTime);

        while (number < maxNumber)
        {
            startEvent.Invoke();
            yield return wsfObj;
            number++;
        }
    }

}
