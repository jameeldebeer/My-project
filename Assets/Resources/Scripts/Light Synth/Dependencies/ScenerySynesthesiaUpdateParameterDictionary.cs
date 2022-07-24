using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenerySynesthesiaUpdateParameterDictionary : MonoBehaviour
{
    public static Dictionary<int, List<ScenerySynesthesiaParameter>> scenerySynesthesiaUpdateParameterDictionary;
    private float intensityTweak = 3.5f;
    void Awake()
    {
        scenerySynesthesiaUpdateParameterDictionary = new Dictionary<int, List<ScenerySynesthesiaParameter>>();

        List<ScenerySynesthesiaParameter> bacterial = new List<ScenerySynesthesiaParameter>();
        bacterial.Add(new ScenerySynesthesiaParameter("SyncToAudioPeer", 0f, 10f));
        bacterial.Add(new ScenerySynesthesiaParameter("Intensity", -10.5f + intensityTweak, -1.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(0, bacterial);

        List<ScenerySynesthesiaParameter> blackLines = new List<ScenerySynesthesiaParameter>();
        blackLines.Add(new ScenerySynesthesiaParameter("LineSize", 0.1f, 0.5f));
        blackLines.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 10f));
        blackLines.Add(new ScenerySynesthesiaParameter("Intensity", -10.5f + intensityTweak, -1.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(1, blackLines);

        List<ScenerySynesthesiaParameter> checkerboard = new List<ScenerySynesthesiaParameter>();
        checkerboard.Add(new ScenerySynesthesiaParameter("CheckerboardFreq", 0.5f, 1.5f));
        checkerboard.Add(new ScenerySynesthesiaParameter("Intensity", -10.5f + intensityTweak, -2.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(2, checkerboard);

        List<ScenerySynesthesiaParameter> herringbone = new List<ScenerySynesthesiaParameter>();
        herringbone.Add(new ScenerySynesthesiaParameter("Cells", 1f, 2f));
        herringbone.Add(new ScenerySynesthesiaParameter("Intensity", -10.5f + intensityTweak, -1.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(3, herringbone);

        List<ScenerySynesthesiaParameter> horrorGlitchList = new List<ScenerySynesthesiaParameter>();
        horrorGlitchList.Add(new ScenerySynesthesiaParameter("Flicker", 0f, 1f));
        horrorGlitchList.Add(new ScenerySynesthesiaParameter("Intensity", -10.5f + intensityTweak, -1.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(4, horrorGlitchList);

        List<ScenerySynesthesiaParameter> noiseEllipse = new List<ScenerySynesthesiaParameter>();
        noiseEllipse.Add(new ScenerySynesthesiaParameter("SyncToAudioPeer", 1f, 5f));
        noiseEllipse.Add(new ScenerySynesthesiaParameter("Intensity", -10.5f + intensityTweak, -1.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(5, noiseEllipse);

        List<ScenerySynesthesiaParameter> parasitic = new List<ScenerySynesthesiaParameter>();
        parasitic.Add(new ScenerySynesthesiaParameter("VoronoiOffset", 2f, 10f));
        parasitic.Add(new ScenerySynesthesiaParameter("Intensity", -8f + intensityTweak, -1.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(6, parasitic);

        List<ScenerySynesthesiaParameter> psychadelicList = new List<ScenerySynesthesiaParameter>();
        psychadelicList.Add(new ScenerySynesthesiaParameter("Posterize", 3.0f, 10f));
        psychadelicList.Add(new ScenerySynesthesiaParameter("VoronoiAngleOffset", 0f, 10f));
        psychadelicList.Add(new ScenerySynesthesiaParameter("Twirl", 0f, 10f));
        psychadelicList.Add(new ScenerySynesthesiaParameter("Intensity", -8f + intensityTweak, -0.8f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(7, psychadelicList);

        List<ScenerySynesthesiaParameter> smoothWave = new List<ScenerySynesthesiaParameter>();
        smoothWave.Add(new ScenerySynesthesiaParameter("Amplitude", 1f, 3f));
        smoothWave.Add(new ScenerySynesthesiaParameter("Intensity", -10.75f + intensityTweak, -2.25f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(8, smoothWave);

        List<ScenerySynesthesiaParameter> spiral = new List<ScenerySynesthesiaParameter>();
        spiral.Add(new ScenerySynesthesiaParameter("Number", 0f, 20f));
        spiral.Add(new ScenerySynesthesiaParameter("Intensity", -10f + intensityTweak, -2f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(9, spiral);

        List<ScenerySynesthesiaParameter> superHexagon = new List<ScenerySynesthesiaParameter>();
        superHexagon.Add(new ScenerySynesthesiaParameter("HexScale", 0.3f, 1f));
        superHexagon.Add(new ScenerySynesthesiaParameter("Intensity", -8f + intensityTweak, -1.5f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(10, superHexagon);

        List<ScenerySynesthesiaParameter> tron = new List<ScenerySynesthesiaParameter>();
        tron.Add(new ScenerySynesthesiaParameter("LineSize", 0.7f, 0.9f));
        tron.Add(new ScenerySynesthesiaParameter("XOffset", 0f, 0.5f));
        tron.Add(new ScenerySynesthesiaParameter("YOffset", 0f, 0.5f));
        tron.Add(new ScenerySynesthesiaParameter("Intensity", -10f + intensityTweak, -1.3f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(11, tron);

        List<ScenerySynesthesiaParameter> truchet = new List<ScenerySynesthesiaParameter>();
        truchet.Add(new ScenerySynesthesiaParameter("Seed", 0f, 15f));
        truchet.Add(new ScenerySynesthesiaParameter("Intensity", -9f + intensityTweak, -3f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(12, truchet);

        List<ScenerySynesthesiaParameter> whirl = new List<ScenerySynesthesiaParameter>();
        whirl.Add(new ScenerySynesthesiaParameter("Number", 1f, 2.5f));
        whirl.Add(new ScenerySynesthesiaParameter("Intensity", -8f + intensityTweak, -1.4f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(13, whirl);

        List<ScenerySynesthesiaParameter> whirlV2 = new List<ScenerySynesthesiaParameter>();
        whirlV2.Add(new ScenerySynesthesiaParameter("Number", 1000f, 1100f));
        whirlV2.Add(new ScenerySynesthesiaParameter("Intensity", -8f + intensityTweak, -1.4f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(14, whirlV2);

        List<ScenerySynesthesiaParameter> zigZag = new List<ScenerySynesthesiaParameter>();
        zigZag.Add(new ScenerySynesthesiaParameter("Amplitude", 1f, 5f));
        zigZag.Add(new ScenerySynesthesiaParameter("Intensity", -9f + intensityTweak, -1.8f + intensityTweak));
        scenerySynesthesiaUpdateParameterDictionary.Add(15, zigZag);
    }
}
