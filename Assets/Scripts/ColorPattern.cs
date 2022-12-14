using System;
using UnityEngine;

public class ColorPattern : ColorButton
{
    HSVColor hsvColor = new HSVColor();
    public int nClicks = 0;
    public float clickTimer = -1;
    public float resetTimer = -1;
    bool updateColorFlag = false;

    public void Start() {
        Setup(new Vector3(-15, 0));
        SetName("ColorPattern");
        SetText("Color Pattern");
        SetColor(hsvColor.Green);
        SetOnClickHandler(() => ColorPatternClicked());
    }

    public void Update() {
        if (clickTimer > 0) {
            if (updateColorFlag) {
                if (nClicks == 1) {
                    SetColor(hsvColor.Blue);
                }
                if (nClicks == 2) {
                    SetColor(hsvColor.Red);
                }
                if (nClicks == 5) {
                    SetColor(hsvColor.Purple);
                }
                updateColorFlag = false;
            }
            clickTimer -= Time.deltaTime;
        } else {
            nClicks = 0;
        }

        if (resetTimer > 0) {
            resetTimer -= Time.deltaTime;
            SetText($"Color Pattern\nResets in {Math.Ceiling(resetTimer)}");

            if (resetTimer <= 0) {
                SetColor(hsvColor.Green);
                SetText("Color Pattern");
            }
        }
    }

    public void ColorPatternClicked() {
        if (clickTimer < 0) {
            clickTimer = 2;
        }
        nClicks++;
        resetTimer = 5;
        updateColorFlag = true;
    }
}
