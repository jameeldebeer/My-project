using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenerySynesthesiaStartParameterDictionary : MonoBehaviour
{
    public static Dictionary<int, List<ScenerySynesthesiaParameter>> scenerySynesthesiaStartParameterDictionary;
    void Awake()
    {
        scenerySynesthesiaStartParameterDictionary = new Dictionary<int, List<ScenerySynesthesiaParameter>>();

        List<ScenerySynesthesiaParameter> bacterial = new List<ScenerySynesthesiaParameter>();
        bacterial.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 2f));
        scenerySynesthesiaStartParameterDictionary.Add(0, bacterial);

        List<ScenerySynesthesiaParameter> blackLines = new List<ScenerySynesthesiaParameter>();
        /**
         * 
         * 
         */
        scenerySynesthesiaStartParameterDictionary.Add(1, blackLines);

        List<ScenerySynesthesiaParameter> checkerboard = new List<ScenerySynesthesiaParameter>();
        /**
         * 
         * 
         */
        scenerySynesthesiaStartParameterDictionary.Add(2, checkerboard);

        List<ScenerySynesthesiaParameter> herringbone = new List<ScenerySynesthesiaParameter>();
        herringbone.Add(new ScenerySynesthesiaParameter("LineSize", 0.05f, 0.1f));
        herringbone.Add(new ScenerySynesthesiaParameter("Tiling", 3f, 5f));
        scenerySynesthesiaStartParameterDictionary.Add(3, herringbone);

        List<ScenerySynesthesiaParameter> horrorGlitchList = new List<ScenerySynesthesiaParameter>();
        /**
         * 
         * 
         */
        scenerySynesthesiaStartParameterDictionary.Add(4, horrorGlitchList);

        List<ScenerySynesthesiaParameter> noiseEllipse = new List<ScenerySynesthesiaParameter>();
        noiseEllipse.Add(new ScenerySynesthesiaParameter("BallSize", 3f, 5f));
        scenerySynesthesiaStartParameterDictionary.Add(5, noiseEllipse);

        List<ScenerySynesthesiaParameter> parasitic = new List<ScenerySynesthesiaParameter>();
        parasitic.Add(new ScenerySynesthesiaParameter("VoronoiCellDensity", 5f, 15f));
        scenerySynesthesiaStartParameterDictionary.Add(6, parasitic);

        List<ScenerySynesthesiaParameter> psychadelicList = new List<ScenerySynesthesiaParameter>();
        psychadelicList.Add(new ScenerySynesthesiaParameter("VoronoiCellDensity", 5f, 10f));
        scenerySynesthesiaStartParameterDictionary.Add(7, psychadelicList);

        List<ScenerySynesthesiaParameter> smoothWave = new List<ScenerySynesthesiaParameter>();
        smoothWave.Add(new ScenerySynesthesiaParameter("Wavelength", 0.5f, 3f));
        smoothWave.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 3f));
        scenerySynesthesiaStartParameterDictionary.Add(8, smoothWave);

        List<ScenerySynesthesiaParameter> spiral = new List<ScenerySynesthesiaParameter>();
        spiral.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 3f));
        spiral.Add(new ScenerySynesthesiaParameter("LineSize", 0.25f, 0.75f));
        spiral.Add(new ScenerySynesthesiaParameter("Separation", 0.5f, 1.5f));
        scenerySynesthesiaStartParameterDictionary.Add(9, spiral);

        List<ScenerySynesthesiaParameter> superHexagon = new List<ScenerySynesthesiaParameter>();
        superHexagon.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 5f));
        scenerySynesthesiaStartParameterDictionary.Add(10, superHexagon);

        List<ScenerySynesthesiaParameter> tron = new List<ScenerySynesthesiaParameter>();
        tron.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 3f));
        scenerySynesthesiaStartParameterDictionary.Add(11, tron);

        List<ScenerySynesthesiaParameter> truchet = new List<ScenerySynesthesiaParameter>();
        truchet.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 4f));
        truchet.Add(new ScenerySynesthesiaParameter("Repetition", 1f, 3f));
        truchet.Add(new ScenerySynesthesiaParameter("LineSize", 0.15f, 0.3f));
        scenerySynesthesiaStartParameterDictionary.Add(12, truchet);

        List<ScenerySynesthesiaParameter> whirl = new List<ScenerySynesthesiaParameter>();
        whirl.Add(new ScenerySynesthesiaParameter("LineSize", 1f, 1.5f));
        whirl.Add(new ScenerySynesthesiaParameter("Tiling", 0.25f, 0.75f));
        whirl.Add(new ScenerySynesthesiaParameter("Rotation", 5f, 15f));
        scenerySynesthesiaStartParameterDictionary.Add(13, whirl);

        List<ScenerySynesthesiaParameter> whirlV2 = new List<ScenerySynesthesiaParameter>();
        whirlV2.Add(new ScenerySynesthesiaParameter("LineSize", 1f, 1.5f));
        whirlV2.Add(new ScenerySynesthesiaParameter("Tiling", 3f, 10f));
        whirlV2.Add(new ScenerySynesthesiaParameter("Rotation", 5f, 15f));
        scenerySynesthesiaStartParameterDictionary.Add(14, whirlV2);


        List<ScenerySynesthesiaParameter> zigZag = new List<ScenerySynesthesiaParameter>();
        zigZag.Add(new ScenerySynesthesiaParameter("Wavelength", 0.5f, 3f));
        zigZag.Add(new ScenerySynesthesiaParameter("Tiling", 2f, 3f));
        scenerySynesthesiaStartParameterDictionary.Add(15, zigZag);
    }
}
