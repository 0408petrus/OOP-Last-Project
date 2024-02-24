using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    public override void DisplayText()
    {
        ShapeText.text = "You select square";
    }
}
