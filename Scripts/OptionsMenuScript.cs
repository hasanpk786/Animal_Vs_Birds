﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenuScript : MonoBehaviour
{
    public AudioMixer audiomixer;
 
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("Volume",Mathf.Log10(volume) * 20);
    }
}
