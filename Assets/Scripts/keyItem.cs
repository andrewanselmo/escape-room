using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "King") {
            GameVariables.keyCount += 1;
            Destroy(gameObject);
        }
    }
}
