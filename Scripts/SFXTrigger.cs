using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXTrigger : MonoBehaviour
{
    public AudioSource playSound;
    void OnTriggerEnter2D(Collider2D collision)
    {
        playSound.Play();
    }
}
