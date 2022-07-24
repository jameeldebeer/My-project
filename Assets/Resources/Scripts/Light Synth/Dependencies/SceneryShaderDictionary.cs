using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryShaderDictionary : MonoBehaviour
{
    public Shader bacterial;
    public Shader blackLines;
    public Shader checkerboard;
    public Shader herringbone;
    public Shader horrorGlitch;
    public Shader noiseEllipse;
    public Shader parasitic;
    public Shader psychadelic;
    public Shader smoothWave;
    public Shader spiral;
    public Shader superHexagon;
    public Shader tron;
    public Shader truchet;
    public Shader whirl;
    public Shader whirlV2;
    public Shader zigZag;

    public static Dictionary<int, Shader> sceneryShaderDictionary;
    void Awake()
    {
        sceneryShaderDictionary = new Dictionary<int, Shader>();
        sceneryShaderDictionary.Add(0, bacterial);
        sceneryShaderDictionary.Add(1, blackLines);
        sceneryShaderDictionary.Add(2, checkerboard);
        sceneryShaderDictionary.Add(3, herringbone);
        sceneryShaderDictionary.Add(4, horrorGlitch);
        sceneryShaderDictionary.Add(5, noiseEllipse);
        sceneryShaderDictionary.Add(6, parasitic);
        sceneryShaderDictionary.Add(7, psychadelic);
        sceneryShaderDictionary.Add(8, smoothWave);
        sceneryShaderDictionary.Add(9, spiral);
        sceneryShaderDictionary.Add(10, superHexagon);
        sceneryShaderDictionary.Add(11, tron);
        sceneryShaderDictionary.Add(12, truchet);
        sceneryShaderDictionary.Add(13, whirl);
        sceneryShaderDictionary.Add(14, whirlV2);
        sceneryShaderDictionary.Add(15, zigZag);
    }
}
