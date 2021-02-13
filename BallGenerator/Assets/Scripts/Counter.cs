using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    public int creditValue=3;
    public IntData numberCount;
    public Text counterText;
    
    // Start is called before the first frame update
    void Start()
    {
        numberCount.value == 0;
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        numberCount.value += creditValue;
        counterText.text = numberCount.value.ToString();
        gameObject.SetActive(false);
    }
}
