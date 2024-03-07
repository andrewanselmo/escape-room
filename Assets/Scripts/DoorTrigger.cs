 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        door.transform.position += new Vector3(0, 8, 0);
    }
}
