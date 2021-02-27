using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public BoolData keyObj;

    // Update is called once per frame
    void Update()
    {
        if (keyObj.value)
        {
            gameObject.SetActive(false);
        }
    }
}
