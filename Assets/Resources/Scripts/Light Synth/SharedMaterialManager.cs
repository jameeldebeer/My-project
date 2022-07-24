using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedMaterialManager : MonoBehaviour
{
    public static SharedMaterialManager sharedMaterialManager;
    public List<Material> sharedMaterialList = new List<Material>();
    private int randomNumberDictKey = 0;
    private int shaderMode;
    private Dictionary<int, int> randomNumberDictionary;
    private List<int> inversionCoefficientList;
    private List<float> updateParameterFloats;
    void Awake()
    {
        updateParameterFloats = new List<float>();
        sharedMaterialManager = this;         
    }

    public void IncrementShaderMode()
    {
        if(shaderMode < SceneryShaderDictionary.sceneryShaderDictionary.Count-1)
        {
            shaderMode++;
            ChangeShader();
        }
        else
        {
            shaderMode = 0;
            ChangeShader();
        }
    }

    public void Start()
    {
        shaderMode = 0;
        ChangeShader();
    }

    public void ChangeShader()
    {
        randomNumberDictionary = new Dictionary<int, int>();
        inversionCoefficientList = new List<int>();
        foreach (Material mat in sharedMaterialList)
        {
            randomNumberDictionary.Add(randomNumberDictKey, UnityEngine.Random.Range(0, 4));
            randomNumberDictKey++;
        }
        foreach (Material mat in sharedMaterialList)
        {
            inversionCoefficientList.Add(Random.Range(0, 2));
        }
        ConfigureStartupParameters();

    }

    void ConfigureStartupParameters()
    {
        int colorIndex = Random.Range(0, 2);
        for (int matIndex = 0; matIndex < sharedMaterialList.Count; matIndex++)
        {
            sharedMaterialList[matIndex].SetColor("PrimaryColor", ColorDictionary.colorDictionary[colorIndex]);
            colorIndex = colorIndex + 2;
            sharedMaterialList[matIndex].SetFloat("Fresnel", 0.1f);
            sharedMaterialList[matIndex].SetFloat("Slider", 0);
            sharedMaterialList[matIndex].shader = SceneryShaderDictionary.sceneryShaderDictionary[shaderMode];
            foreach (ScenerySynesthesiaParameter i in ScenerySynesthesiaStartParameterDictionary.scenerySynesthesiaStartParameterDictionary[shaderMode])
            {
                sharedMaterialList[matIndex].SetFloat(i.shaderVariableHexCode, i.lowerLimit + (i.upperLimit - i.lowerLimit) * Random.value);
            }
        }
    }

    public Material GetRandomSharedMaterial()
    {
        return sharedMaterialList[Random.Range(0, sharedMaterialList.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        for(int matIndex = 0; matIndex < sharedMaterialList.Count; matIndex++)
        {
            foreach (ScenerySynesthesiaParameter i in ScenerySynesthesiaUpdateParameterDictionary.scenerySynesthesiaUpdateParameterDictionary[shaderMode])
            {
                sharedMaterialList[matIndex].SetFloat(i.shaderVariableHexCode, i.lowerLimit + (i.upperLimit - i.lowerLimit) * Mathf.Abs(inversionCoefficientList[matIndex] - Mathf.Clamp(AudioPeer.audioBandBuffer[matIndex], 0.1f, 1.0f)));
            }
        }
    }
}
