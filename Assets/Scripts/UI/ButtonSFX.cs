using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip highlightSound;
    public AudioClip clickSound;

    public void HoverSound()
    {
        mySound.PlayOneShot(highlightSound);
    }

    public void ClickSound()
    {
        mySound.PlayOneShot(clickSound);
    }
}
