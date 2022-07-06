using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToPlayField : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colider playgame");
        other.transform.position = transform.position;
        other.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
