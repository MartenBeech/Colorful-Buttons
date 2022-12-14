using UnityEngine;

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
        SetColor(Random.ColorHSV());
    }
}
