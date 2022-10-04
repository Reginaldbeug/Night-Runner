using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft = 3.0f;

    public TextMeshProUGUI timerText;

    public GameObject youLose;

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = (timeLeft).ToString("0");
        }

        if(timeLeft <= 0)
        {
            youLose.SetActive(true);
            GetComponent<FirstPersonController>().enabled = false;
        }
    }
}
