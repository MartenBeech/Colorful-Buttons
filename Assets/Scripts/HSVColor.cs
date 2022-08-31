using UnityEngine;

public class HSVColor : MonoBehaviour
{
    Color green = Color.HSVToRGB(120 / 360f, 1, 1);
    public Color Green {
        get { return green; }
    }

    Color blue = Color.HSVToRGB(240 / 360f, 1, 1);
    public Color Blue {
        get { return blue; }
    }

    Color red = Color.HSVToRGB(0 / 360f, 1, 1);
    public Color Red {
        get { return red; }
    }

    Color purple = Color.HSVToRGB(270 / 360f, 1, 1);
    public Color Purple {
        get { return purple; }
    }

}
