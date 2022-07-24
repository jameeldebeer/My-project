using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScenerySynesthesiaParameter
{
    public string shaderVariableHexCode;
    public float lowerLimit;
    public float upperLimit;
    public ScenerySynesthesiaParameter(string shaderVariableHexCode, float lowerLimit, float upperLimit)
    {
        this.shaderVariableHexCode = shaderVariableHexCode;
        this.lowerLimit = lowerLimit;
        this.upperLimit = upperLimit;
    }
}
