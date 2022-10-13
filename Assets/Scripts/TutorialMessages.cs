using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.UI;

public class TutorialMessages : MonoBehaviour
{
    public GameObject tutorialBoard;
    public GameObject objective1;
    public GameObject objective2;
    public GameObject objective3;
    public GameObject objective4;
    public GameObject objective5;
    public GameObject objective6;
    public GameObject objective7;

    private void Start()
    {
        tutorialBoard.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("trigger1"))
        {
            objective1.SetActive(true);
        }
        else
        {
            objective1.SetActive(false);
        }

        if (other.gameObject.CompareTag("trigger2"))
        {
            objective2.SetActive(true);
        }
        else
        {
            objective2.SetActive(false);
        }

        if (other.gameObject.CompareTag("trigger3"))
        {
            objective3.SetActive(true);
        }
        else
        {
            objective3.SetActive(false);
        }

        if (other.gameObject.CompareTag("trigger4"))
        {
            objective4.SetActive(true);
        }
        else
        {
            objective4.SetActive(false);
        }

        if (other.gameObject.CompareTag("trigger5"))
        {
            objective5.SetActive(true);
        }
        else
        {
            objective5.SetActive(false);
        }

        if (other.gameObject.CompareTag("trigger6"))
        {
            objective6.SetActive(true);
        }
        else
        {
            objective6.SetActive(false);
        }

        if (other.gameObject.CompareTag("trigger7"))
        {
            objective7.SetActive(true);
        }
        else
        {
            objective7.SetActive(false);
        }

        if (other.gameObject.CompareTag("trigger8"))
        {
            tutorialBoard.SetActive(false);
        }
    }
}
