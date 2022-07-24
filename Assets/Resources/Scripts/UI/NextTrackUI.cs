using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTrackUI : MonoBehaviour
{
    public void NextTrackClicked()
    {
        PlayBackgroundMusic.playBackgroundMusic.NextTrack();
    }
}
