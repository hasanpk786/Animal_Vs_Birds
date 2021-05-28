using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource playSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playSound.Play();
    }
}
