using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public AudioSource audioSource;

    public static AudioManager audioManager;

    private PlayBackgroundMusic playBackgroundMusic;
    void Awake()
    {
        if (audioManager == null)
            audioManager = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        playBackgroundMusic = GetComponent<PlayBackgroundMusic>();
    }

    public PlayBackgroundMusic GetPlayBackgroundMusic()
    {
        return playBackgroundMusic;
    }


    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source = audioSource;
        s.source.clip = s.clip;
        s.source.volume = s.volume;
        s.source.pitch = s.pitch;
        s.source.loop = s.loop;
        s.source.Play();
    }

    public List<string> GetAllSongNames()
    {
        /**
        * This creates a list of the song names in order.
        */

        List<string> allSongNames = new List<string>();
        string tmpString;
        foreach (Sound s in sounds)
        {
            tmpString = s.name;
            allSongNames.Add(tmpString);
        }

        return allSongNames;
    }
}