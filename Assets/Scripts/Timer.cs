using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Threading;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject Clock;
    public GameObject youLose;
    public GameObject youWin;

    public float timeLeft = 10.0f;
    public float time = 3.0f;

    public TextMeshProUGUI timerText;

    private void Start()
    {
        Clock.SetActive(false);
    }

    void Update()
    {
        if (Clock.activeSelf)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timerText.text = (timeLeft).ToString("0");

                if (timeLeft <= 0)
                {
                    youLose.SetActive(true);
                    GetComponent<FirstPersonController>().enabled = false;
                }
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Entrance"))
        {
            Clock.SetActive(true);

            timeLeft = 10.0f;
        }

        if (other.gameObject.CompareTag("Exit"))
        {
            timeLeft = 10.0f;

            Clock.SetActive(false);

            youWin.SetActive(true);
        }

        if (other.gameObject.CompareTag("Winner"))
        {
            youWin.SetActive(false);
        }
    }
}
