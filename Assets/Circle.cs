using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    public override void DisplayText()
    {
        ShapeText.text = "You select circle";
    }
}
