using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManagerScript : MonoBehaviour
{
    public SoundScript[] sounds;
    public static AudioManagerScript Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (SoundScript s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.group;
        }
    }

    public void Play(string name)
    {
       SoundScript s = Array.Find(sounds, sound =>sound.name == name);
        Debug.Log(s);
        if (s == null)
        {
            Debug.LogWarning("Sound Name not found");
            return;
        }
        s.source.Play();
    }

    public void Looper(string name , bool looper, bool play)
    {
        SoundScript s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound Name not found");
            return;
        }
        s.source.loop = looper;
        if(play==true)
        s.source.Play();

    }
}
