using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyGate : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "King" && GameVariables.keyCount > 0)
        {

            GameVariables.keyCount--;
            Destroy(gameObject);
            
        }
        
    }
}
