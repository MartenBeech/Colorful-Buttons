using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class ColorPatternTest
{
    [Test]
    public void TestColorPatternNClicks()
    {
        ColorPattern colorPattern = new ColorPattern();

        Assert.AreEqual(0, colorPattern.nClicks);

        colorPattern.ColorPatternClicked();
        Assert.AreEqual(1, colorPattern.nClicks);

        colorPattern.ColorPatternClicked();
        Assert.AreEqual(2, colorPattern.nClicks);
    }

    [Test]
    public void TestColorPatternTimersActivate() {
        var colorPattern = new ColorPattern();

        Assert.AreEqual(-1, colorPattern.resetTimer);
        Assert.AreEqual(-1, colorPattern.clickTimer);

        colorPattern.ColorPatternClicked();
        Assert.AreEqual(5, colorPattern.resetTimer);
        Assert.AreEqual(2, colorPattern.clickTimer);
    }

    [Test]
    public void TestColorPatternButtonColor() {
        var colorPattern = new ColorPattern();
        var hsvColor = new HSVColor();

        colorPattern.Start();
        GameObject gameObject = colorPattern.colorButton;
        Assert.AreEqual(hsvColor.Green, gameObject.GetComponent<Image>().color);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(hsvColor.Blue, gameObject.GetComponent<Image>().color);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(hsvColor.Red, gameObject.GetComponent<Image>().color);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(hsvColor.Red, gameObject.GetComponent<Image>().color);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(hsvColor.Red, gameObject.GetComponent<Image>().color);

        colorPattern.ColorPatternClicked();
        colorPattern.Update();
        Assert.AreEqual(hsvColor.Purple, gameObject.GetComponent<Image>().color);
    }

    [Test]
    public void TestRandomColorButtonColor() {
        var randomColor = new RandomColor();

        randomColor.Start();
        GameObject gameObject = randomColor.colorButton;
        Assert.AreEqual(Color.white, gameObject.GetComponent<Image>().color);

        randomColor.RandomColorClicked();
        Assert.AreNotEqual(Color.white, gameObject.GetComponent<Image>().color);
    }
}
