using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextShaderUI : MonoBehaviour
{
    public void NextShaderClicked()
    {
        SharedMaterialManager.sharedMaterialManager.IncrementShaderMode();
    }
}
