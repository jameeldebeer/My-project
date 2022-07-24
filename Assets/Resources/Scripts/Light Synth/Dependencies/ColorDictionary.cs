using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDictionary : MonoBehaviour
{
    private Color White;
    private Color Yellow;
    private Color Orange;
    private Color Red;
    private Color Magenta;
    private Color Purple;
    private Color Blue;
    private Color Cyan;
    private Color Green;
    private Color DarkGreen;
    private Color Brown;
    private Color Tan;
    private Color LightGrey;
    private Color MediumGrey;
    private Color DarkGrey;
    private Color Black;

    public static Dictionary<int, Color> colorDictionary;
 
    // Start is called before the first frame update
    void Awake()
    {
        White = new Color(1, 1, 1);
        Yellow = new Color(1, 1, 0);
        Orange = new Color(1, 0.65f, 0);
        Red = new Color(1, 0, 0);
        Magenta = new Color(1, 0, 1);
        Purple = new Color(0.5f, 0, 0.5f);
        Blue = new Color(0, 0, 1);
        Cyan = new Color(0, 1, 1);
        Green = new Color(0, 1, 0);
        DarkGreen = new Color(0, 0.39f, 0);
        Brown = new Color(0.65f, 0.17f, 0.17f);
        Tan = new Color(0.82f, 0.71f, 0.55f);
        LightGrey = new Color(0.83f, 0.83f, 0.83f);
        MediumGrey = new Color(0.66f, 0.66f, 0.66f);
        DarkGrey = new Color(0.39f, 0.39f, 0.39f);
        Black = new Color(0, 0, 0);

        colorDictionary = new Dictionary<int, Color>();

        colorDictionary.Add(0, White);
        colorDictionary.Add(1, Yellow);
        colorDictionary.Add(2, Orange);
        colorDictionary.Add(3, Red);
        colorDictionary.Add(4, Magenta);
        colorDictionary.Add(5, Purple);
        colorDictionary.Add(6, Blue);
        colorDictionary.Add(7, Cyan);
        colorDictionary.Add(8, Green);
        colorDictionary.Add(9, DarkGreen);
        colorDictionary.Add(10, Brown);
        colorDictionary.Add(11, Tan);
        colorDictionary.Add(12, LightGrey);
        colorDictionary.Add(13, MediumGrey);
        colorDictionary.Add(14, DarkGrey);
        colorDictionary.Add(15, Black);
    }
}
