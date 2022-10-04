using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRemover : MonoBehaviour
{
    public GameObject Floor;

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            Floor.SetActive(true);
        }
    }
}
