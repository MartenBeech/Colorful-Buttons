using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    public GameObject randomColor;

    public void Start() {
        GameObject prefab = Resources.Load<GameObject>("Assets/ColorButton");
        GameObject parent = GameObject.Find("Canvas");

        randomColor = Instantiate(prefab, new Vector3(15, 0), parent.transform.rotation, parent.transform);
        randomColor.name = "RandomColor";
        randomColor.GetComponentInChildren<Text>().text = "Random Color";
        randomColor.GetComponent<Image>().color = Color.white;
        randomColor.GetComponent<Button>().onClick.AddListener(() => RandomColorClicked(randomColor));
    }

    public void RandomColorClicked(GameObject btn) {
        btn.GetComponent<Image>().color = UnityEngine.Random.ColorHSV();
    }
}
