using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource button;
    public void playButton()
    {
        button.Play();
    }
}
