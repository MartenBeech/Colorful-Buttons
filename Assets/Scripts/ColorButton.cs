using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    

    private void Start() {
        GameObject colorPattern;
        GameObject randomColor;
        GameObject prefab = Resources.Load<GameObject>("Assets/ColorButton");
        GameObject parent = GameObject.Find("Canvas");

        colorPattern = Instantiate(prefab, new Vector3(-15, 0), parent.transform.rotation, parent.transform);
        colorPattern.name = "ColorPattern";
        colorPattern.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Color Pattern";

        randomColor = Instantiate(prefab, new Vector3(15, 0), parent.transform.rotation, parent.transform);
        randomColor.name = "RandomColor";
        randomColor.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Random Color";
        randomColor.GetComponent<Button>().onClick.AddListener(() => RandomColorClicked(randomColor));
    }

    private void RandomColorClicked(GameObject btn) {
        btn.GetComponent<Image>().color = UnityEngine.Random.ColorHSV();
    }
}
