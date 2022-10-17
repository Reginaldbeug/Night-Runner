using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelText : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("level1"))
        {
            level1.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("level2"))
        {
            level2.SetActive(true);
        }
       
        if (other.gameObject.CompareTag("level3"))
        {
            level3.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("level4"))
        {
            level4.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("level1"))
        {
            level1.SetActive(false);
        }

        if (other.gameObject.CompareTag("level2"))
        {
            level2.SetActive(false);
        }

        if (other.gameObject.CompareTag("level3"))
        {
            level3.SetActive(false);
        }

        if (other.gameObject.CompareTag("level4"))
        {
            level4.SetActive(false);
        }
    }
}
