using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public GameObject _colorButton;
    public GameObject _prefab;
    public GameObject _parent;
    public void Setup(Vector3 pos) {
        _prefab = Resources.Load<GameObject>("Assets/ColorButton");
        _parent = GameObject.Find("Canvas");

        _colorButton = Instantiate(_prefab, pos, _parent.transform.rotation, _parent.transform);
    }

    public void SetName(string name) {
        _colorButton.name = name;
    }

    public void SetText(string text) {
        _colorButton.GetComponentInChildren<Text>().text = text;
    }

    public void SetColor(Color color) {
        _colorButton.GetComponent<Image>().color = color;
    }

    public void SetOnClickHandler(Action handler) {
        _colorButton.GetComponent<Button>().onClick.AddListener(() => handler());
    }
}
