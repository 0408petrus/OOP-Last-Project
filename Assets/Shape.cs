using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI ShapeText;
    public virtual void DisplayText()
    {
        ShapeText.text = "Please select the shape";
    }
}
