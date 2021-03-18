using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehavior : MonoBehaviour
{

    public string[] playerNames;
    
    private IEnumerator Start()
    {
        foreach (var playerName in playerNames)
        {
            print(playerName);
        }

        while (true)
        {
            yield return new WaitForSeconds(1);
            print("Hello");
        }
        
    }

}
