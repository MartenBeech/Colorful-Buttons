using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPattern : MonoBehaviour
{
    HSVColor hsvColor = new HSVColor();
    GameObject colorPattern;
    int nClicks = 0;
    float clickTimer = -1;
    float resetTimer = -1;
    bool updateColorFlag = false;

    private void Start() {
        
        GameObject prefab = Resources.Load<GameObject>("Assets/ColorButton");
        GameObject parent = GameObject.Find("Canvas");

        colorPattern = Instantiate(prefab, new Vector3(-15, 0), parent.transform.rotation, parent.transform);
        colorPattern.name = "ColorPattern";
        colorPattern.GetComponentInChildren<Text>().text = "Color Pattern";
        colorPattern.GetComponent<Image>().color = hsvColor.Green;
        colorPattern.GetComponent<Button>().onClick.AddListener(() => ColorPatternClicked());
    }

    private void Update() {
        if (clickTimer > 0) {
            if (updateColorFlag) {
                if (nClicks == 1) {
                    colorPattern.GetComponent<Image>().color = hsvColor.Blue;
                }
                if (nClicks == 2) {
                    colorPattern.GetComponent<Image>().color = hsvColor.Red;
                }
                if (nClicks == 5) {
                    colorPattern.GetComponent<Image>().color = hsvColor.Purple;
                }
                updateColorFlag = false;
            }
            clickTimer -= Time.deltaTime;
        } else {
            nClicks = 0;
        }

        if (resetTimer > 0) {
            resetTimer -= Time.deltaTime;

            if (resetTimer <= 0) {
                colorPattern.GetComponent<Image>().color = hsvColor.Green;
            }
        }
    }

    private void ColorPatternClicked() {
        if (clickTimer < 0) {
            clickTimer = 2;
        }
        nClicks++;
        resetTimer = 5;
        updateColorFlag = true;
    }
}
