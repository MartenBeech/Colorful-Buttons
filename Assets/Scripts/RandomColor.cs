using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : ColorButton
{
    public void Start() {
        Setup(new Vector3(15, 0));
        SetName("RandomColor");
        SetText("Random Color");
        SetColor(Color.white);
        SetOnClickHandler(() => RandomColorClicked());
    }

    public void RandomColorClicked() {
        SetColor(UnityEngine.Random.ColorHSV());
    }
}
