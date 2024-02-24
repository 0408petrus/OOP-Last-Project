using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{
    public override void DisplayText()
    {
        ShapeText.text = "You select triangle";
    }
}
