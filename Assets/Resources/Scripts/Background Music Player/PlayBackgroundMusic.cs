using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBackgroundMusic : MonoBehaviour
{
    public static PlayBackgroundMusic playBackgroundMusic;
    private List<string> soundList;
    private AudioManager backgroundMusicAudioManager;
    private AudioSource backgroundMusicAudioSource;
    private int currentTrack;

    void Awake()
    {
        backgroundMusicAudioManager = GetComponent<AudioManager>();
        backgroundMusicAudioSource = GetComponent<AudioSource>();
        currentTrack = 0;
        playBackgroundMusic = this;
    }

    void Start()
    {
        soundList = AudioManager.audioManager.GetAllSongNames();
        PlayBackgroundTrack(currentTrack);
    }

    public void NextTrack()
    {
        if(currentTrack < soundList.Count)
        {
            currentTrack++;
            PlayBackgroundTrack(currentTrack);
        }
        else
        {
            currentTrack = 0;
        }
    }

    public void PlayBackgroundTrack(int songIndex)
    {
        backgroundMusicAudioManager.Play(soundList[songIndex]);
    }


    public string returnClipName(int songIndex)
    {
        return soundList[songIndex];
    }

    public string returnClipLength()
    {
        return backgroundMusicAudioSource.clip.length.ToString();
    }
}
