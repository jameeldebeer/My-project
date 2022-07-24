using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPeer : MonoBehaviour
{
    public AudioSource backgroundMusic;

    public static float[] samplesLeft = new float[512];
    public static float[] samplesRight = new float[512];


    float[] freqBands = new float[4];
    float[] bandBuffer = new float[4];
    float[] bufferDecrease = new float[4];

    //bool particleInstanceReady = true;
    
    float[] freqBandHighest = new float[4];
    public static float[] audioBand = new float[4];
    public static float[] audioBandBuffer = new float[4];

    public static float amplitude, amplitudeBuffer;
    public static float amplitudeHighest;

    private float lastHighAmplitude;

    public float audioProfile;

    public enum _channel{Stereo, Left, Right};
    public _channel channel = new _channel();

    private void Awake()
    {
        audioProfile = 4; //Lower number more intense... Higher number is gentler.
        AudioProfile(audioProfile);
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
        BandBuffer();
        CreateAudioBands();
        GetAmplitude();
        if(SceneManager.GetActiveScene().name == "GameLevel")
        {
            //InstantiateSceneryParticles();
        }
    }

    void AudioProfile(float audioProfile)
    {
        for (int i = 0; i < 4; i++)
        {
            freqBandHighest[i] = audioProfile;
        }
    }

    void GetAmplitude()
    {
        float currentAmplitude = 0;
        float currentAmplitudeBuffer = 0;
        for (int i = 0; i < 4; i++)
        {
            currentAmplitude += audioBand[i];
            currentAmplitudeBuffer += audioBandBuffer[i];
        }
        if (currentAmplitude > amplitudeHighest)
        {
            amplitudeHighest = currentAmplitude;
        }
        amplitude = currentAmplitude / amplitudeHighest;
        amplitudeBuffer = currentAmplitudeBuffer / amplitudeHighest;

    }

    void CreateAudioBands()
    {
        for (int i = 0; i <4; i++)
        {
            if (freqBands [i] > freqBandHighest[i])
            {
                freqBandHighest[i] = freqBands[i];
            }
            audioBand[i] = (freqBands[i] / freqBandHighest[i]);
            audioBandBuffer[i] = (bandBuffer[i] / freqBandHighest[i]);
        }
    }


    void GetSpectrumAudioSource()
    {
        backgroundMusic.GetSpectrumData(samplesLeft, 0, FFTWindow.Blackman);
        backgroundMusic.GetSpectrumData(samplesRight, 1, FFTWindow.Blackman);
    }

    void BandBuffer()
    {
        for (int g = 0; g < 4; g++)
        {
            if (freqBands[g] > bandBuffer[g])
            {
                bandBuffer[g] = freqBands[g];
                //bufferDecrease[g] = 0.005f; // DEFAULT FROM TUTORIAL
                bufferDecrease[g] = 0.005f;

            }
            if (freqBands[g] < bandBuffer[g])
            {
                bandBuffer[g] -= bufferDecrease[g];
                bufferDecrease[g] *= 1.2f; // DEFAULT FROM TUTORIAL
                //bufferDecrease[g] *= 3f * Time.deltaTime;

            }
        }
    }

    //Take some time to review the method below... This seems a bit nuts.
    //Source Audio Visualization - Unity/C# Tutorial Part 4
    void MakeFrequencyBands()
    {
        int count = 0;

        for (int i = 0; i < 4; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;

            if (i == 3)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                if (channel == _channel.Stereo)
                {
                    average += (samplesLeft[count] + samplesRight[count]) * (count + 1);
                }
                if (channel == _channel.Left)
                {
                    average += samplesLeft[count] * (count + 1);
                }
                if (channel == _channel.Right)
                {
                    average += samplesRight[count] * (count + 1);
                }
                count++;
            }
            average /= count;
            freqBands[i] = average * 10;

        }
    }
}

/**
void InstantiateSceneryParticles()
{

    /**
     * Dumber more performant version. This should be the one!
     */
/**
if (amplitudeBuffer > 0.7f && particleInstanceReady)
{
    DOLObjectPooler.Instance.SpawnFromPool("DigitalVortexParticlesL" + UnityEngine.Random.Range(1, 9).ToString(), new Vector3(0f, 0f, PlayerSpaceShipControl.playerSpaceShipControl.fppTransform.position.z +20f), Quaternion.identity);

    lastHighAmplitude = amplitudeBuffer;
    particleInstanceReady = false;
}
if (amplitudeBuffer < (lastHighAmplitude -0.08f) && !particleInstanceReady)
{
    particleInstanceReady = true;
}
*/
/**
        for (int i = 0; i < 8; i++)
        {
            if (audioBandBuffer[i] > 0.75f && particleInstanceReady)
            {
                DOLObjectPooler.Instance.SpawnFromPool("DigitalVortexParticles", new Vector3(0f, 0f, TransformManager.FPP.position.z), Quaternion.identity);
                particleInstanceReady = false;
            }
            if (audioBandBuffer[i] < 0.5f && !particleInstanceReady)
            {
                particleInstanceReady = true;
            }
        }
*/
