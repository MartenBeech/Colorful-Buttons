using System;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public GameObject colorButton;
    public GameObject prefab;
    public GameObject parent;
    public void Setup(Vector3 pos) {
        prefab = Resources.Load<GameObject>("Assets/ColorButton");
        parent = GameObject.Find("Canvas");

        colorButton = Instantiate(prefab, pos, parent.transform.rotation, parent.transform);
    }

    public void SetName(string name) {
        colorButton.name = name;
    }

    public void SetText(string text) {
        colorButton.GetComponentInChildren<Text>().text = text;
    }

    public void SetColor(Color color) {
        colorButton.GetComponent<Image>().color = color;
    }

    public void SetOnClickHandler(Action handler) {
        colorButton.GetComponent<Button>().onClick.AddListener(() => handler());
    }
}
