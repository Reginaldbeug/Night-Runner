using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Teleporter : MonoBehaviour
{
    public Transform Destination;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = Destination.position;
    }
}
